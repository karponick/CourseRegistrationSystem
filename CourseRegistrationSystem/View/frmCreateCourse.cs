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
    public partial class frmCreateCourse : Form
    {
        private bool validation = true;
        private readonly Dictionary<string, Course> courseList = new Dictionary<string, Course>();
        private readonly Dictionary<string, Course> newCourseList = new Dictionary<string, Course>(); // For file output
        private List<string> prereqList = new List<string>();
        private readonly DatabaseControllerV2 dbc;
        private bool forModification;
        //private string oldCode;
        // Constructor
        public frmCreateCourse()
        {
            InitializeComponent();
            forModification = false;
            this.courseList = frmMain.CourseList;
            this.dbc = frmMain.Dbc;
            foreach (string code in courseList.Keys) { comboPrereqs.Items.Add(code); }
        }
        // Methods
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
            if (courseList.ContainsKey(txtCode.Text) && !forModification) 
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
                    Code = txtCode.Text,
                    Department = comboDepartment.GetItemText(comboDepartment.SelectedItem),
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

                if (forModification) // If modifying course, then just update it
                {
                    dbc.ModifyCourse(course.ToArray());
                    // If the Unique course code is changed, then the old reference in the 
                    // dictionary must be removed. 
                    //if (course.Code != oldCode)
                    //{
                    //    dbc.DeleteCourse(oldCode);
                    //    dbc.AddCourse(course.ToArray());
                    //    frmMain.CourseList.Remove(oldCode);
                    //}
                    //else
                    //{
                    //    dbc.ModifyCourse(course.ToArray());
                    //}
                }
                else // else make new entry
                {
                    dbc.AddCourse(course.ToArray());
                }
                frmMain.CourseList[course.Code] = course;
            }
            else
            {
                lblStatus.Text = "Error: Invalid data.";
                lblStatus.ForeColor = Color.Red;
            }
        }

        public void ModifiedLayout(Course course)
        {
            forModification = true;
            txtCode.Enabled = false;
            txtSeatsMax.Enabled = false;
            txtSeatsAvail.Enabled = false;
            //oldCode = course.Code;

            txtCode.Text = course.Code;
            comboDepartment.SelectedIndex = comboDepartment.Items.IndexOf(course.Department);
            txtTitle.Text = course.Title;
            txtDescription.Text = course.Description;
            txtCredits.Text = course.Credits;
            prereqList = course.Prereqs;
            foreach (string prereq in prereqList) { lstPrereqs.Items.Add(prereq); }
            txtTimeStart.Text = course.StartTime;
            txtTimeEnd.Text = course.EndTime;
            txtSeatsMax.Text = course.SeatsMax;
            txtSeatsAvail.Text = course.SeatsAvail;
            txtProf.Text = course.Professor;
            txtProfImgUrl.Text = course.ProfessorImgUrl;
            Text = "Modifying course...";

            int i = 0;
            foreach (CheckBox chk in flowDays.Controls.OfType<CheckBox>())
            {
                if (course.Days[i]) { chk.Checked = true; }
                i++;
            }


        }

        private void btnViewList_Click(object sender, EventArgs e)
        {
            frmCourseListing newCourseListing = new frmCourseListing(false, this);
            newCourseListing.ShowDialog();
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
            frmRegistration registrationForm = new frmRegistration();
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
