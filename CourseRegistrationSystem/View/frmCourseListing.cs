using System;
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
        private Dictionary<string, Course> courseList = new Dictionary<string, Course>();
        private List<string> defaultCodeList;
        private List<string> currentCodeList; // Either full list or filtered list
        readonly DetailPanel detailPanel;
        private int page, maxPages;
        private readonly bool forRegistration;
        private Course selectedCourse;
        private readonly Form parentForm;
        private readonly DatabaseControllerV2 dbc;

        // Constructor
        public frmCourseListing(bool forRegistration, Form parentForm)
        {
            InitializeComponent();
            this.dbc = frmMain.Dbc;
            this.forRegistration = forRegistration; // Adds button to Detail Panel for student registration
            this.parentForm = parentForm;
            if (!forRegistration) { btnCreate.Visible = true; }

            // Set course lists for display
            this.courseList = frmMain.CourseList;
            defaultCodeList = courseList.Keys.ToList();
            currentCodeList = defaultCodeList;
            dgvCourses.RowTemplate.Height = 40;
            page = 0;
            maxPages = 0;
            // Create panel for course details
            detailPanel = new DetailPanel(this, dbc);
            Controls.Add(detailPanel);

            // Add all course data to datagrid
            UpdateDataGrid();
            if (maxPages > 0) { btnNext.Enabled = true; }
        }
        // Methods
        private void UpdateDataGrid()
        {
            // CLear
            dgvCourses.Rows.Clear();
            foreach (var control in dgvCourses.Controls)
            {
                if (control is MeetingPanel meetingPanel)
                {
                    meetingPanel.Visible = false;
                }
            }
            CloseDetailPanel();

            // Populate
            maxPages = currentCodeList.Count / 10;

            for (int i = 0; i < 10; i++)
            {
                int index = i + page * 10;
                // If index reaches out of bounds stop adding to data grid
                if (index > currentCodeList.Count - 1) { break; }

                // Add course to data grid
                Course course = courseList[currentCodeList[index]];
                string[] courseInfo = { course.Code, course.Title, course.TimeString(),
                course.CapacityString(), course.Professor};

                // Datagridview implementation
                dgvCourses.Rows.Add(courseInfo);
            }
            CloseDetailPanel();

        }

        public void CloseDetailPanel()
        {
            if (detailPanel != null)
            {
                dgvCourses.ClearSelection();
                detailPanel.HideDetails();
            }
        }

        private void RefreshList()
        {
            courseList = frmMain.CourseList;
            defaultCodeList = courseList.Keys.ToList();
            currentCodeList = defaultCodeList;
            UpdateDataGrid();
        }

        // Events
        private void frmCourseListing_Load(object sender, EventArgs e)
        {
            // Need this event to clear selected row when launching courselist view and detail panel
            dgvCourses.ClearSelection();
            if (detailPanel != null) { detailPanel.Visible = false; }
        }
        // Event for when row is selected/deselected - Displays Course Details Panel
        private void dgvCourses_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            DataGridViewRow row = e.Row;
            if (row.Selected) 
            {
                // Get details for selected course
                DataGridViewRow selectedItem = dgvCourses.SelectedRows[0];
                string selectedCode = selectedItem.Cells[0].Value.ToString();
                selectedCourse = courseList[selectedCode];
                detailPanel.Populate(selectedCourse);

                // Enable modification buttons 
                if (forRegistration)
                {
                    btnAddtoReg.Visible = true;
                }
                else
                {
                    btnModify.Visible = true;
                    btnDelete.Visible = true;
                }
            }
            else
            {
                // Close details for deselected course
                if (forRegistration)
                {
                    btnAddtoReg.Visible = false;
                }
                else
                {
                    btnModify.Visible = false;
                    btnDelete.Visible = false;
                }
                CloseDetailPanel();
            }
        }
        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            page = 0;
            btnPrev.Enabled = false;
            ComboBox cmb = (ComboBox)sender;
            // if filter selection is reset, display entire list
            if (cmb.SelectedIndex == -1) { currentCodeList = defaultCodeList; }
            // else display filtered list
            else
            { 
                List<string> filteredCourseList = new List<string>();
                foreach (string courseCode in defaultCodeList)
                {
                    Course course = courseList[courseCode];
                    if (course.Department == (string)cmb.SelectedItem) { filteredCourseList.Add(courseCode); }
                }
                currentCodeList = filteredCourseList;
            }
            lblShowing.Text = "Page " + (page + 1).ToString();
            UpdateDataGrid();
            if (maxPages > 0) { btnNext.Enabled = true; }
            else { btnNext.Enabled = false; }
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            page--;
            if (page == 0) { btnPrev.Enabled = false; }
            if (page < maxPages) { btnNext.Enabled = true; }
            lblShowing.Text = "Page " + (page + 1).ToString();
            UpdateDataGrid();
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
            UpdateDataGrid();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateCourse newCreateCourse = new frmCreateCourse();
            newCreateCourse.ShowDialog();
            RefreshList();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            // !!!!!!! NEED to implement modified version where values are filled
            // and submitting updates instead of creates
            // certain values like Code and Seating cannot be changed through this, maybe?
            frmCreateCourse newCreateCourse = new frmCreateCourse();
            newCreateCourse.ModifiedLayout(selectedCourse);
            newCreateCourse.ShowDialog();
            RefreshList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete from database
            dbc.DeleteCourse(selectedCourse.Code);
            // Delete from courselist
            frmMain.CourseList.Remove(selectedCourse.Code);
            // Update display
            RefreshList();
        }

        private void btnAddtoReg_Click(object sender, EventArgs e)
        {
            int.TryParse(selectedCourse.SeatsAvail, out int availableSeats);
            if (availableSeats > 0)
            {
                // Add course to student registration
                frmRegistration parent = parentForm as frmRegistration;
                if (parent.AddCourse(selectedCourse)) // if added successfully
                {
                    selectedCourse.SeatsAvail = (--availableSeats).ToString();
                    UpdateDataGrid();
                }
            }
            else
            {
                MessageBox.Show("No seats available.");
            }
        }
    }
}
