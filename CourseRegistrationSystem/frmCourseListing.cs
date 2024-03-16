using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistrationSystem
{
    public partial class frmCourseListing : Form
    {
        // Fields
        private readonly List<Course> courseList;
        private List<Course> currentList;
        Panel courseDisplay;
        private int page, maxPages;

        // Constructor
        public frmCourseListing(List<Course> courseList, ComboBox.ObjectCollection departmentList)
        {
            InitializeComponent();
            this.courseList = courseList;
            this.currentList = courseList;
            datGrdVwCourses.RowTemplate.Height = 40;
            foreach (string department  in departmentList)
            {
                cmbFilter.Items.Add(department);
            }
            page = 0;
            maxPages = 0;
            // Create panel for course details
            courseDisplay = new Panel
            {
                Size = new Size(400, 370),
                Location = new Point(350, 30),//(312, 13),
                BackColor = Color.LightGray,
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false
            };
            Controls.Add(courseDisplay);

            // Add all course data to listview
            PopulateDataGrid();
        }
        // Methods
        private void PopulateDataGrid()
        {
            maxPages = currentList.Count / 10;
            if (maxPages > 0) { btnNext.Enabled = true; }

            int meetingTimeLabelHeightPositionModifier = 0;
            for (int i = 0; i < 10; i++)
            {
                int index = i + page * 10;
                // If index reaches out of bounds stop adding to data grid
                if (index > currentList.Count - 1) { return; }

                // Add course to data grid
                Course course = currentList[index];
                string[] courseInfo = { course.Code, course.Title, course.TimeString(),
                course.CapacityString(), course.Professor};

                // Datagridview implementation
                datGrdVwCourses.Rows.Add(courseInfo);

                Panel meetingTimes = new MeetingTimes(course.Days, course.TimeString())
                {
                    //Location = new Point(314, 40 * i + 34)
                    Location = new Point(302, 40 * meetingTimeLabelHeightPositionModifier + 22)
                };
                datGrdVwCourses.Controls.Add(meetingTimes);
                meetingTimeLabelHeightPositionModifier++;
            }
            datGrdVwCourses.ClearSelection();
            datGrdVwCourses.Update();
        }
        private void CloseDetailPanel()
        {
            if (courseDisplay != null)
            {
                courseDisplay.Controls.Clear();
            }
            datGrdVwCourses.ClearSelection();
            courseDisplay.Visible = false;
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
                if (control is MeetingTimes)
                {
                    datGrdVwCourses.Controls.Remove((MeetingTimes)control);
                }
            }
            //datGrdVwCourses.Controls.Clear();
            CloseDetailPanel();
        }

        // Events
        private void listViewCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Selecting a course code opens a details panel */
            if (listViewCourses.SelectedItems.Count != 0)
            {
                // Create panel for selected course details
                courseDisplay = new FlowLayoutPanel
                {
                    Size = new Size(400, 300),
                    Location = new Point(300, 50),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.Fixed3D
                };
                // Get details for selected course
                ListViewItem selectedItem = listViewCourses.SelectedItems[0];
                string selectedCode = selectedItem.SubItems[0].Text;
                Course selectedCourse = null;
                foreach (Course course in courseList)
                {
                    if (course.Code == selectedCode)
                    {
                        selectedCourse = course;
                        break;
                    }
                }

                // All controls for details within details panel
                Label lblCode = new Label
                {
                    Text = selectedCourse.Code,
                    Size = new Size(100, 20),
                };
                Label lblTitle = new Label
                {
                    Text = selectedCourse.Title,
                    Size = new Size(200, 20),
                };
                Label lblDescription = new Label
                {
                    Text = selectedCourse.Description,
                    Size = new Size(400, 40),
                };

                Panel meetingTimes = new MeetingTimes(selectedCourse.Days, selectedCourse.TimeString());

                Label lblProfessor = new Label
                {
                    Text = selectedCourse.Professor,
                    Size = new Size(100, 20),
                };
                PictureBox picProfImg = new PictureBox
                {
                    Size = new Size(100, 100),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                //picProfImgUrl.Load(selectedCourse.ProfessorImgUrl);
                string tempurl = "https://i.kym-cdn.com/entries/icons/original/000/027/475/Screen_Shot_2018-10-25_at_11.02.15_AM.png";
                picProfImg.Load(tempurl);
                
                Label lblCapacity = new Label
                {
                    Text = selectedCourse.CapacityString(),
                    Size = new Size(100, 20),
                };
                Label lblCredits = new Label
                {
                    Text = selectedCourse.Credits,
                    Size = new Size(100, 20),
                };

                // Add all controls to form
                this.Controls.Add(courseDisplay);
                courseDisplay.BringToFront();

                courseDisplay.Controls.Add(lblCode);
                courseDisplay.Controls.Add(lblTitle);
                courseDisplay.Controls.Add(lblDescription);
                //courseDisplay.Controls.Add(lblDays);
                //courseDisplay.Controls.Add(lblTime);
                courseDisplay.Controls.Add(meetingTimes);
                courseDisplay.Controls.Add(lblProfessor);
                courseDisplay.Controls.Add(picProfImg);
                courseDisplay.Controls.Add(lblCapacity);
                courseDisplay.Controls.Add(lblCredits);

            }
        }

        // Need this to clear selected row when launching courselist view and detail panel
        private void frmCourseListing_Load(object sender, EventArgs e)
        {
            datGrdVwCourses.ClearSelection();
            if (courseDisplay != null) { courseDisplay.Visible = false; }
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
                Course selectedCourse = null;
                foreach (Course course in currentList)
                {
                    if (course.Code == selectedCode)
                    {
                        selectedCourse = course;
                        break;
                    }
                }

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

                Panel meetingTimes = new MeetingTimes(selectedCourse.Days, selectedCourse.TimeString())
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(10, 190)
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
                catch { }
                

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
                courseDisplay.Controls.Add(lblCode);
                courseDisplay.Controls.Add(lblTitle);
                courseDisplay.Controls.Add(lblDescription);
                courseDisplay.Controls.Add(meetingTimes);
                courseDisplay.Controls.Add(lblProfessor);
                courseDisplay.Controls.Add(picProfImg);
                courseDisplay.Controls.Add(lblCapacity);
                courseDisplay.Controls.Add(lblCredits);

                courseDisplay.Controls.Add(btnClose);

                // Make course panel visible
                courseDisplay.Visible = true;
                courseDisplay.BringToFront();
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
            ComboBox cmb = (ComboBox)sender;
            // if filter selection is reset, display entire list
            if (cmb.SelectedIndex == -1) { currentList = courseList; page = 0; }
            // else display filtered list
            else
            { 
                List<Course> filteredCourseList = new List<Course>();
                foreach (Course c in courseList)
                {
                    if (c.Department == (string)cmb.SelectedItem) { filteredCourseList.Add(c); }
                }
                page = 0;
                currentList = filteredCourseList;
            }
            ClearDataGrid();
            PopulateDataGrid();
        }

        

        private void btnPrev_Click(object sender, EventArgs e)
        {
            page--;
            if (page == 0) { btnPrev.Enabled = false; }
            else if (page != maxPages) { btnNext.Enabled = true; }
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
            else if (page != 0) { btnPrev.Enabled = true; }
            lblShowing.Text = "Page " + (page + 1).ToString();
            ClearDataGrid();
            PopulateDataGrid();
        }
    }
}
