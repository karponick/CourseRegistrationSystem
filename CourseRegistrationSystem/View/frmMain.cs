using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CourseRegistrationSystem
{
    public partial class frmMain : Form
    {
        private bool validation = true;
        private readonly Dictionary<string, Course> courseList = new Dictionary<string, Course>();
        private readonly Dictionary<string, Course> newCourseList = new Dictionary<string, Course>(); // For file outpu
        private readonly List<string> prereqList = new List<string>();
        private readonly DatabaseController dbc;


        // Constructor
        public frmMain()
        {
            InitializeComponent();
            dbc = new DatabaseController();

            // Database stuff
            DataTable tableCourses = dbc.GetTable("Courses"); // Get existing data from db
            foreach (DataRow row in tableCourses.Rows)
            {
                List<string> courseData = new List<string>();
                foreach (object col in row.ItemArray)
                {
                    courseData.Add(col.ToString());
                }
                CreateCourse(courseData); // Create course and add to list
            }
        }

        // Methods
        public void CreateCourse(List<string> data)
        {
            string code = data[0];
            courseList[code] = new Course(data);
            comboPrereqs.Items.Add(code);
        }

        private bool InputValidatoin()
        {
            // Input validation
            bool noErrors = true;

            // Department
            if (comboDepartment.SelectedIndex == -1)
            {
                lblDep.ForeColor = Color.Red;
                noErrors = false;
            }
            else { lblDep.ForeColor = default; }

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
            if (!int.TryParse(txtSeatsMax.Text, out int maxSeats) ||
                !int.TryParse(txtSeatsAvail.Text, out int availSeats) ||
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

            return noErrors;
        }

        // Events
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;

            // if course code is already in list, then return (dont submit)
            if (courseList.ContainsKey(txtCode.Text)) 
            {
                lblStatus.Text = "Error: Course with this code already exists in list.";
                lblStatus.ForeColor = Color.Red;
                return; 
            }
            // Submission does validation checks and collects all the data that was input in controls
            bool noErrors = InputValidatoin();

            // If there are no input errors, gather info and submit new course
            if (noErrors || !validation)
            {
                Course course = new Course
                {
                    Department = comboDepartment.GetItemText(comboDepartment.SelectedItem),
                    Code = txtCode.Text,
                    Title = txtTitle.Text,
                    Description = txtDescription.Text,
                    Credits = txtCredits.Text,
                    Prereqs = prereqList,
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
                courseList[course.Code] = course;
                newCourseList[course.Code] = course;
                lblStatus.Text = "Course submitted successfully.";
                lblStatus.ForeColor = Color.Green;
                dbc.UpdateTable(courseList);
            }
            else
            {
                lblStatus.Text = "Error: Invalid data.";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            frmCourseListing newCourseList = new frmCourseListing(courseList, false, this);
            newCourseList.ShowDialog();
        }

        private void Numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Used by code, maxseats, and availseats textboxes
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
            lblDep.ForeColor = default;
            lstPrereqs.Items.Clear();
            prereqList.Clear();
            foreach (TextBox txt in Controls.OfType<TextBox>())
            {
                txt.Clear();
                txt.BackColor = default;
            }
            picProf.Image = null;
            foreach (CheckBox chk in flowDays.Controls)
            {
                chk.Checked = false;
            }
            lblStatus.Text = string.Empty;
        }

        private void txtProfImgUrl_TextChanged(object sender, EventArgs e)
        {
            try 
            { 
                picProf.Load(txtProfImgUrl.Text);
                picProf.SizeMode = PictureBoxSizeMode.StretchImage;
            } catch (Exception) 
            { 
                Console.WriteLine("Image could not be loaded.");
            }
        }

        private void btnValidation_Click(object sender, EventArgs e)
        {
            validation = !validation;
            if (validation) { btnValidation.BackColor = Color.LightGreen; }
            else { btnValidation.BackColor = Color.LightPink; }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            frmRegistration registrationForm = new frmRegistration(courseList);
            registrationForm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboPrereqs.SelectedIndex >= 0) 
            {
                //string code = comboPrereqs.Items[comboPrereqs.SelectedIndex].ToString();
                string code = comboPrereqs.GetItemText(comboPrereqs.SelectedItem);
                if (!prereqList.Contains(code))
                {
                    prereqList.Add(code);
                    lstPrereqs.Items.Add(code);
                }
            }
        }
    }
}
