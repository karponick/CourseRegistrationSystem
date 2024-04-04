using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// CIS 3309 Lab 4
// Nicholas Karpovitch

/* Apologies to anyone that ends up having to look through this mess of code.
 * I wanted to try to simplify some things and reduce amount of references everywhere,
 * But due to my own procrastination I didn't get around to it, and the tech debt grew.
 * Things sort of "worked", and I needed to get other requirements to work, so I ended
 * up building on the poor but working implementations.
 * 
 * I'll probably go back and refactor a lot of redundant code if I have time in the future,
 * but for now it more or less works to fit the requirements, I think >.>
 * 
 * If there are any questions about functionality or implementation please let me know
 * so I can clear up any potential confusion my messy code causes ~
 */
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
