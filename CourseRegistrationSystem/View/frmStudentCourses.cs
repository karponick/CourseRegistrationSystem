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
    public partial class frmStudentCourses : Form
    {
        readonly Dictionary<string, Course> courseList;
        readonly DatabaseControllerV2 dbc;
        public frmStudentCourses()
        {
            InitializeComponent();
            this.courseList = frmMain.CourseList;
            this.dbc = frmMain.Dbc;
        }
        private void cmbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCourses.Rows.Clear();
            List<string> courseCodes = dbc.GetStudentCourseCodes(txtStudentID.Text);
            foreach (string code in courseCodes)
            {
                dgvCourses.Rows.Add(courseList[code].ToArray());
            }
            dgvCourses.ClearSelection();
        }
    }
}
