using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace CourseRegistrationSystem
{
    public partial class frmMain : Form
    {
        // Fields
        private List<Course> courseList;

        // Constructor
        public frmMain()
        {
            InitializeComponent();
            courseList = new List<Course>();

            List<string> courseData = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader("course_list.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line == string.Empty)
                        {
                            CreateCourse(courseData);
                            courseData.Clear();
                        }
                        else { courseData.Add(line); }
                    }
                    CreateCourse(courseData);
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        // Used for creating courses from text file
        public void CreateCourse(List<string> data)
        {
            Course course = new Course
            {
                Department = data[0],
                Code = data[1],
                Title = data[2],
                Description = data[3],
                Credits = data[4],
                // prereqs
                StartTime = data[7],
                EndTime = data[8],
                SeatsMax = data[9],
                SeatsAvail = data[10],
                Professor = data[11],
                ProfessorImgUrl = data[12],
            };
            for (int i = 0; i < 5; i++)
            {
                string dayString = data[6];
                if (dayString[i] == 'T') { course.Days[i] = true; }
                else if (dayString[i] == 'F') { course.Days[i] = false; }
            }
            courseList.Add(course);
        }

        // Events
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool noErrors = true;
            lblStatus.Visible = false;

            // if course code is already in list, then return (dont submit)
            foreach (Course c in courseList)
            {
                if (txtCode.Text == c.Code) 
                {
                    lblStatus.Visible = true;
                    lblStatus.Text = "Error: Course with this code already exists in list.";
                    lblStatus.ForeColor = Color.Red;
                    return; 
                }
            }

            // Input validation

            // Department
            if (comboDepartment.SelectedIndex == -1)
            {
                lblDep.ForeColor = Color.Red;
                noErrors = false;
            }
            else { comboDepartment.BackColor = default; }

            // Empty checks for: Code, Title, Description, maxseats, availseats, credits 
            List<TextBox> txtList = new List<TextBox>
            {
                txtCode, txtTitle, txtDescription, txtSeatsMax, txtSeatsAvail, txtCredits
            };
            foreach (TextBox txt in txtList)
            {
                if (txt.Text.Length == 0)
                {
                    txt.BackColor = Color.LightPink;
                    noErrors = false;
                }
                else
                {
                    txt.BackColor = default;
                }
            }

            // Seats (Max and Avail)
            if (! int.TryParse(txtSeatsMax.Text, out int maxSeats) ||
                ! int.TryParse(txtSeatsAvail.Text, out int availSeats) ||
                availSeats > maxSeats)
            {
                txtSeatsMax.BackColor = Color.LightPink;
                txtSeatsAvail.BackColor = Color.LightPink;
                noErrors = false;
            }
            else
            {
                txtSeatsMax.BackColor = default;
                txtSeatsAvail.BackColor = default;
            }

            // Time (Start and End)

            // Image url
            noErrors = true;
            // If there are no input errors, gather info and submit new course
            if (noErrors)
            {
                Course course = new Course
                {
                    Department = comboDepartment.SelectedText,
                    Code = txtCode.Text,
                    Title = txtTitle.Text,
                    Description = txtDescription.Text,
                    Credits = txtCredits.Text,
                    // prereqs
                    StartTime = txtTimeStart.Text,
                    EndTime = txtTimeEnd.Text,
                    SeatsMax = txtSeatsMax.Text,
                    SeatsAvail = txtSeatsAvail.Text,
                    Professor = txtProf.Text,
                    ProfessorImgUrl = txtProfImgUrl.Text,
                };
                // If a day is checked, add to list of days for that course
                int i = 0;
                foreach (CheckBox chk in flowDays.Controls.OfType<CheckBox>())
                {
                    if (chk.Checked) { course.Days[i] = true; }
                    i++;
                }
                courseList.Add(course);
                lblStatus.Visible = true;
                lblStatus.Text = "Course submitted successfully.";
                lblStatus.ForeColor = Color.Green;
                return;
            }
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            frmCourseListing newCourseList = new frmCourseListing(courseList, comboDepartment.Items);
            newCourseList.ShowDialog();
        }

        // Used by code, maxseats, and availseats textboxes
        private void Numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check if key pressed is a number
            if (!int.TryParse(e.KeyChar.ToString(), out _) && !Char.IsControl(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboDepartment.SelectedIndex = -1;
            txtCode.Clear();
            txtTitle.Clear();
            txtDescription.Clear();
            txtCredits.Clear();
            //prereqs
            txtTimeStart.Clear();
            txtTimeEnd.Clear();
            txtSeatsMax.Clear();
            txtSeatsAvail.Clear();
            txtProf.Clear();
            txtProfImgUrl.Clear();
            picProf.Image = null;
            foreach (CheckBox chk in flowDays.Controls)
            {
                chk.Checked = false;
            }
        }

        private void txtProfImgUrl_TextChanged(object sender, EventArgs e)
        {
            try 
            { 
                picProf.Load(txtProfImgUrl.Text);
                picProf.SizeMode = PictureBoxSizeMode.StretchImage;
            } catch { }
        }
    }
}
