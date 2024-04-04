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
    public partial class frmStudentList : Form
    {
        public frmStudentList(DataView source)
        {
            InitializeComponent();
            dgvStudents.DataSource = source;
            //dgvStudents.Columns[0].HeaderText = "Student ID";
            //dgvStudents.Columns[1].HeaderText = "Student Name";
            //dgvStudents.Update();
        }

        private void frmStudentList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Owner != null)
            {
                frmStudentCourses temp = Owner as frmStudentCourses;
                temp.SetBtnFalse();
            }
        }
    }
}
