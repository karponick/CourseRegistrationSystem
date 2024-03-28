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
    public partial class frmMain : Form
    {
        private static readonly DatabaseControllerV2 dbc = new DatabaseControllerV2();
        private static Dictionary<string, Course> courseList = new Dictionary<string, Course>();

        public frmMain()
        {
            InitializeComponent();

            // Database stuff
            courseList = dbc.GetCourseList();
        }

        public static Dictionary<string, Course> CourseList {  get { return courseList; } }
        public static DatabaseControllerV2 Dbc { get { return dbc; } }

        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            frmCreateCourse newCreateCourse = new frmCreateCourse();
            newCreateCourse.ShowDialog();
        }

        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            frmCourseListing newCourseListing = new frmCourseListing(false, this);
            newCourseListing.ShowDialog();
        }

        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            frmRegistration newRegistration = new frmRegistration();
            newRegistration.ShowDialog();
        }

        private void btnStudentCourses_Click(object sender, EventArgs e)
        {
            frmStudentCourses newStudentCourses = new frmStudentCourses();
            newStudentCourses.ShowDialog();
        }
    }
}
