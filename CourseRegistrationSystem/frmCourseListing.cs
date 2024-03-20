using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CourseRegistrationSystem
{
    public partial class frmCourseListing : Form
    {
        // Fields
        private readonly List<string> defaultCodeList;
        private List<string> currentList;
        readonly Panel detailPanel;
        private int page, maxPages;

        // Constructor
        public frmCourseListing(ComboBox.ObjectCollection departmentList)
        {
            InitializeComponent();
            defaultCodeList = Course.CourseList.Keys.ToList();
            currentList = defaultCodeList;
            datGrdVwCourses.RowTemplate.Height = 40;
            foreach (string department  in departmentList)
            {
                cmbFilter.Items.Add(department);
            }
            page = 0;
            maxPages = 0;
            // Create panel for course details
            detailPanel = new Panel
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
                Course course = Course.CourseList[currentList[index]];
                string[] courseInfo = { course.Code, course.Title, course.TimeString(),
                course.CapacityString(), course.Professor};

                // Datagridview implementation
                datGrdVwCourses.Rows.Add(courseInfo);

                Panel meetingTimes = GetMeetingPanel(course, new Point(302, 40 * meetingTimeLabelHeightPositionModifier + 22));
                datGrdVwCourses.Controls.Add(meetingTimes);
                meetingTimeLabelHeightPositionModifier++;
            }
            CloseDetailPanel();

        }
        private void CloseDetailPanel()
        {
            if (detailPanel != null)
            {
                detailPanel.Controls.Clear();
                datGrdVwCourses.ClearSelection();
                detailPanel.Visible = false;
            }
        }
        private void ModifyDetailLabel(Label lbl)
        {
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lbl.BackColor = Color.White;
            lbl.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void ClearDataGrid()
        {
            datGrdVwCourses.Rows.Clear();
            foreach(var control in datGrdVwCourses.Controls)
            {
                if (control is MeetingTimes times)
                {
                    times.Visible = false;
                }
            }
            CloseDetailPanel();
        }
        // Datagrid can access static list of all existing course MeetingTime panels
        private MeetingTimes GetMeetingPanel(Course course, Point location)
        {
            MeetingTimes meetingTimes;
            if (MeetingTimes.MeetingTimesList.ContainsKey(course.Code))
            {
                meetingTimes = MeetingTimes.MeetingTimesList[course.Code];
                meetingTimes.Location = location;
            }
            else
            {
                meetingTimes = new MeetingTimes(course.Days, course.TimeString(), course.Code)
                {
                    Location = location
                };
            }
            meetingTimes.Visible = true;
            return meetingTimes;
        }

        // Events
        // Need this to clear selected row when launching courselist view and detail panel
        private void frmCourseListing_Load(object sender, EventArgs e)
        {
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
                Course selectedCourse = Course.CourseList[selectedCode];

                // PANEL IS 400x370

                // All controls for details within details panel
                Label lblCode = new Label
                {
                    Text = selectedCourse.Code,
                    Size = new Size(100, 40),
                    Location = new Point(10, 10),
                };
                ModifyDetailLabel(lblCode);

                Label lblTitle = new Label
                {
                    Text = selectedCourse.Title,
                    Size = new Size(270, 40),
                    Location = new Point(120, 10),
                };
                ModifyDetailLabel(lblTitle);

                Label lblDescription = new Label
                {
                    Text = selectedCourse.Description,
                    Size = new Size(380, 120),
                    Location = new Point(10, 60),
                };
                ModifyDetailLabel(lblDescription);

                Panel meetingTimes = new MeetingTimes(selectedCourse.Days, selectedCourse.TimeString(), null)
                {
                    Location = new Point(10, 190),
                    BorderStyle = BorderStyle.FixedSingle
                };

                Label lblProfessor = new Label
                {
                    Text = selectedCourse.Professor,
                    Size = new Size(199, 40),
                    Location = new Point(10, 240),
                };
                ModifyDetailLabel(lblProfessor);

                PictureBox picProfImg = new PictureBox
                {
                    Size = new Size(170, 170),
                    Location = new Point(220, 190),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };
                try { picProfImg.Load(selectedCourse.ProfessorImgUrl); }
                catch (Exception ex) { Console.WriteLine("Image could not be loaded. " + ex.Message); }
                

                Label lblCapacity = new Label
                {
                    Text = selectedCourse.CapacityString(),
                    Size = new Size(95, 40),
                    Location = new Point(10, 290),
                };
                ModifyDetailLabel(lblCapacity);

                Label lblCredits = new Label
                {
                    Text = selectedCourse.Credits + " credits",
                    Size = new Size(94, 40),
                    Location = new Point(115, 290),
                };
                ModifyDetailLabel(lblCredits);

                Button btnClose = new Button
                {
                    Text = "Close",
                    Size = new Size(199, 20),
                    Location = new Point(10, 340),
                    BackColor = Color.CornflowerBlue
                };
                btnClose.Click += btnClose_Click;


                // Add all controls to panel
                detailPanel.Controls.Add(lblCode);
                detailPanel.Controls.Add(lblTitle);
                detailPanel.Controls.Add(lblDescription);
                detailPanel.Controls.Add(meetingTimes);
                detailPanel.Controls.Add(lblProfessor);
                detailPanel.Controls.Add(picProfImg);
                detailPanel.Controls.Add(lblCapacity);
                detailPanel.Controls.Add(lblCredits);

                detailPanel.Controls.Add(btnClose);

                // Make course detail panel visible
                detailPanel.Visible = true;
                detailPanel.BringToFront();
            }

            else
            {
                // Close details for deselected course
                CloseDetailPanel();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseDetailPanel();
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
                    Course course = Course.CourseList[courseCode];
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
    }
}
