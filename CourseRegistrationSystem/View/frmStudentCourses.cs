using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistrationSystem
{
    public partial class frmStudentCourses : Form
    {
        readonly Dictionary<string, Course> courseList;
        readonly DatabaseControllerV2 dbc;
        frmStudentList newStudentList;
        public frmStudentCourses()
        {
            InitializeComponent();
            this.courseList = frmMain.CourseList;
            this.dbc = frmMain.Dbc;
        }

        // Methods
        public void SetBtnFalse()
        {
            btnViewStudents.BackColor = Color.LightPink;
            newStudentList = null;
        }

        // Events
        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSemester.SelectedIndex != -1 && dgvCourses.Rows.Count > 0)
            {
                dgvCourses.Rows.Clear();
                string semester = cmbSemester.GetItemText(cmbSemester.SelectedItem);
                List<string> courseCodes = dbc.GetStudentCourseCodes(txtStudentID.Text, semester);
                foreach (string code in courseCodes)
                {
                    dgvCourses.Rows.Add(courseList[code].ToArray());
                }
                dgvCourses.ClearSelection();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cmbSemester.SelectedIndex = -1;
            dgvCourses.Rows.Clear();
            List<string> courseCodes = dbc.GetStudentCourseCodes(txtStudentID.Text, null);
            foreach (string code in courseCodes)
            {
                dgvCourses.Rows.Add(courseList[code].ToArray());
            }
            dgvCourses.ClearSelection();
        }
        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            if (newStudentList == null)
            {
                btnViewStudents.BackColor = Color.LightGreen;
                newStudentList = new frmStudentList(dbc.GetAllStudents())
                {
                    Owner = this
                };
                newStudentList.Show();
            }
            else
            {
                btnViewStudents.BackColor = Color.LightPink;
                newStudentList.Close();
                newStudentList = null;
            }
        }

        private void dgvCourses_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try { picImage.Load(dgvCourses.Rows[e.RowIndex].Cells[12].Value.ToString()); }
                catch (Exception)
                {
                    Console.WriteLine("Image could not be loaded.");
                    picImage.Image = null;
                }
            }
        }
    }
}
