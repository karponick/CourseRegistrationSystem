using System;
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
    public partial class frmRegistration : Form
    {
        private readonly Dictionary<string, Course> courseList = new Dictionary<string, Course>();
        private readonly Dictionary<string, Course> registeredCourses = new Dictionary<string, Course>();
        private double totalCredits;
        public frmRegistration(Dictionary<string, Course> courseList)
        {
            InitializeComponent();
            this.courseList = courseList;
            totalCredits = 0;
        }
        public bool AddCourse(Course course)
        {
            // Returns True if added succesfully, False if day/time conflict

            // NOTE: To Add a course to Registration, after starting program navigate like so:
            // frmMain > click "Student Registration" > click View Courses >
            // > click any course to open Detail Panel > click green Add button

            //Console.WriteLine(string.Format("c: {0}, d: {1}, t: {2}, p: {3}",
            //    course.Code, course.DayString(), course.TimeString(), course.Professor));

            foreach (string code in registeredCourses.Keys) // iterate through registered courses
            {
                Course comparingCourse = registeredCourses[code];
                if (course.TimeString() == comparingCourse.TimeString()) // check if time conflict
                {
                    for (int i = 0; i < 5; i++) // check day conflict
                    {
                        if (course.Days[i] == comparingCourse.Days[i])
                        {
                            MessageBox.Show("Day/Time Conflict.");
                            return false;
                        }
                    }
                }
            }
            string[] details = { course.Code, course.DayString(), course.TimeString(), course.Professor };
            lstCourses.Items.Add(new ListViewItem(details));
            registeredCourses.Add(course.Code, course);

            double.TryParse(course.Credits, out double credits);
            totalCredits += credits;
            UpdateCost();
            return true;
        }
        private void UpdateCost()
        {
            if (totalCredits > 0)
            {
                lblCost.Text = string.Format("$700 / Credit Hour = ${0} for {1} total credits.",
                    (totalCredits * 700).ToString(), totalCredits.ToString());
            }
            else 
            {
                lblCost.Text = "$700 / Credit Hour";
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmCourseListing newCourseList = new frmCourseListing(courseList, true, this);
            newCourseList.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            cmbSemester.SelectedIndex = -1;
            lstCourses.Items.Clear();
            totalCredits = 0;
            UpdateCost();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Registration newRegistration = new Registration
                (
                    txtID.Text, 
                    txtName.Text, 
                    cmbSemester.GetItemText(cmbSemester.SelectedItem), 
                    registeredCourses
                );
        }
        private void lstCourses_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListViewItem row = e.Item;
            if (row.Selected)
            {
                btnRemove.Visible = true;
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            btnRemove.Visible = false;
            foreach (ListViewItem row in lstCourses.SelectedItems)
            {
                Course course = registeredCourses[row.SubItems[0].Text];
                
                double.TryParse(course.Credits, out double credits);
                totalCredits -= credits;
                lstCourses.Items.Remove(row);
                registeredCourses.Remove(course.Code);
            }
            UpdateCost();
        }

    }
}
