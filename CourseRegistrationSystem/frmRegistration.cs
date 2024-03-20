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
        public frmRegistration(Dictionary<string, Course> courseList)
        {
            InitializeComponent();
            this.courseList = courseList;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmCourseListing newCourseList = new frmCourseListing(courseList);
            newCourseList.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
