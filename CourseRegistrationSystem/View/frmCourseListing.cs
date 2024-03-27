﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace CourseRegistrationSystem
{
    public partial class frmCourseListing : Form
    {
        // Fields
        private readonly Dictionary<string, Course> courseList = new Dictionary<string, Course>();
        private readonly List<string> defaultCodeList;
        private List<string> currentList;
        readonly DetailPanel detailPanel;
        private int page, maxPages;
        private readonly bool forRegistration;
        private Course selectedCourse;
        private readonly Form parentForm;

        // Constructor
        public frmCourseListing(Dictionary<string, Course> courseList, bool forRegistration, Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.forRegistration = forRegistration; // Adds button to Detail Panel for student registration
            this.courseList = courseList;
            defaultCodeList = courseList.Keys.ToList();
            currentList = defaultCodeList;
            datGrdVwCourses.RowTemplate.Height = 40;
            page = 0;
            maxPages = 0;
            // Create panel for course details
            detailPanel = new DetailPanel(this)
            {
                Size = new Size(400, 370),
                Location = new Point(350, 30),//(312, 13),
                BackColor = Color.LightGray,
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false
            };
            Controls.Add(detailPanel);

            // Add all course data to datagrid
            PopulateDataGrid();
            if (maxPages > 0) { btnNext.Enabled = true; }
        }
        // Methods
        private void PopulateDataGrid()
        {
            maxPages = currentList.Count / 10;

            int meetingTimeLabelHeightPositionModifier = 0;
            for (int i = 0; i < 10; i++)
            {
                int index = i + page * 10;
                // If index reaches out of bounds stop adding to data grid
                if (index > currentList.Count - 1) { break; }

                // Add course to data grid
                Course course = courseList[currentList[index]];
                string[] courseInfo = { course.Code, course.Title, course.TimeString(),
                course.CapacityString(), course.Professor};

                // Datagridview implementation
                datGrdVwCourses.Rows.Add(courseInfo);

                Panel meetingPanel = GetMeetingPanel(course, new Point(302, 40 * meetingTimeLabelHeightPositionModifier + 22));
                //datGrdVwCourses.Controls.Add(meetingPanel);
                meetingTimeLabelHeightPositionModifier++;
            }
            CloseDetailPanel();

        }

        public void CloseDetailPanel()
        {
            if (detailPanel != null)
            {
                datGrdVwCourses.ClearSelection();
                detailPanel.HideDetails();
            }
        }
        private void ClearDataGrid()
        {
            datGrdVwCourses.Rows.Clear();
            foreach(var control in datGrdVwCourses.Controls)
            {
                if (control is MeetingPanel meetingPanel)
                {
                    meetingPanel.Visible = false;
                }
            }
            CloseDetailPanel();
        }
        // Datagrid can access static list of all existing course MeetingTime panels
        private MeetingPanel GetMeetingPanel(Course course, Point location)
        {
            MeetingPanel meetingPanel;
            if (MeetingPanel.MeetingPanelList.ContainsKey(course.Code))
            {
                meetingPanel = MeetingPanel.MeetingPanelList[course.Code];
                meetingPanel.Location = location;
            }
            else
            {
                meetingPanel = new MeetingPanel()
                {
                    Location = location
                };
                meetingPanel.Populate(course.Days, course.TimeString(), course.Code);
            }
            meetingPanel.Visible = true;
            return meetingPanel;
        }

        // Events
        private void frmCourseListing_Load(object sender, EventArgs e)
        {
            // Need this event to clear selected row when launching courselist view and detail panel
            datGrdVwCourses.ClearSelection();
            if (detailPanel != null) { detailPanel.Visible = false; }
        }
        // Event for when rows are selected/deselected - Displays Course Details Panel
        private void datGrdVwCourses_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            DataGridViewRow row = e.Row;
            if (row.Selected) 
            {
                // Get details for selected course
                DataGridViewRow selectedItem = datGrdVwCourses.SelectedRows[0];
                string selectedCode = selectedItem.Cells[0].Value.ToString();
                selectedCourse = courseList[selectedCode];
                detailPanel.Populate(selectedCourse, forRegistration);
            }
            else
            {
                // Close details for deselected course
                CloseDetailPanel();
            }
        }
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            page = 0;
            btnPrev.Enabled = false;
            ComboBox cmb = (ComboBox)sender;
            // if filter selection is reset, display entire list
            if (cmb.SelectedIndex == -1) { currentList = defaultCodeList; }
            // else display filtered list
            else
            { 
                List<string> filteredCourseList = new List<string>();
                foreach (string courseCode in defaultCodeList)
                {
                    Course course = courseList[courseCode];
                    if (course.Department == (string)cmb.SelectedItem) { filteredCourseList.Add(courseCode); }
                }
                currentList = filteredCourseList;
            }
            lblShowing.Text = "Page " + (page + 1).ToString();
            ClearDataGrid();
            PopulateDataGrid();
            if (maxPages > 0) { btnNext.Enabled = true; }
            else { btnNext.Enabled = false; }
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            page--;
            if (page == 0) { btnPrev.Enabled = false; }
            if (page < maxPages) { btnNext.Enabled = true; }
            lblShowing.Text = "Page " + (page + 1).ToString();
            ClearDataGrid();
            PopulateDataGrid();
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Clear filter selection
            cmbFilter.SelectedIndex = -1;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            page++;
            if (page == maxPages) { btnNext.Enabled = false; }
            if (page > 0) { btnPrev.Enabled = true; }
            lblShowing.Text = "Page " + (page + 1).ToString();
            ClearDataGrid();
            PopulateDataGrid();
        }

        // Events called from Detail Panel
        public void btnAdd_Click()
        {
            int.TryParse(selectedCourse.SeatsAvail, out int availableSeats);
            if (availableSeats > 0)
            {
                // Add course to student registration
                frmRegistration parent = parentForm as frmRegistration;
                if (parent.AddCourse(selectedCourse)) // if added successfully
                {
                    selectedCourse.SeatsAvail = (--availableSeats).ToString();
                    ClearDataGrid();
                    PopulateDataGrid();
                }
            }
            else
            {
                MessageBox.Show("No seats available.");
            }
        }
    }
}