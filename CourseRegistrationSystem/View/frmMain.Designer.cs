namespace CourseRegistrationSystem
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateCourse = new System.Windows.Forms.Button();
            this.btnViewCourses = new System.Windows.Forms.Button();
            this.btnRegisterStudent = new System.Windows.Forms.Button();
            this.btnStudentCourses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateCourse
            // 
            this.btnCreateCourse.Location = new System.Drawing.Point(12, 12);
            this.btnCreateCourse.Name = "btnCreateCourse";
            this.btnCreateCourse.Size = new System.Drawing.Size(100, 50);
            this.btnCreateCourse.TabIndex = 0;
            this.btnCreateCourse.TabStop = false;
            this.btnCreateCourse.Text = "Create Course";
            this.btnCreateCourse.UseVisualStyleBackColor = true;
            this.btnCreateCourse.Click += new System.EventHandler(this.btnCreateCourse_Click);
            // 
            // btnViewCourses
            // 
            this.btnViewCourses.Location = new System.Drawing.Point(118, 12);
            this.btnViewCourses.Name = "btnViewCourses";
            this.btnViewCourses.Size = new System.Drawing.Size(100, 50);
            this.btnViewCourses.TabIndex = 1;
            this.btnViewCourses.TabStop = false;
            this.btnViewCourses.Text = "View Courses";
            this.btnViewCourses.UseVisualStyleBackColor = true;
            this.btnViewCourses.Click += new System.EventHandler(this.btnViewCourses_Click);
            // 
            // btnRegisterStudent
            // 
            this.btnRegisterStudent.Location = new System.Drawing.Point(224, 12);
            this.btnRegisterStudent.Name = "btnRegisterStudent";
            this.btnRegisterStudent.Size = new System.Drawing.Size(100, 50);
            this.btnRegisterStudent.TabIndex = 2;
            this.btnRegisterStudent.TabStop = false;
            this.btnRegisterStudent.Text = "Register Student";
            this.btnRegisterStudent.UseVisualStyleBackColor = true;
            this.btnRegisterStudent.Click += new System.EventHandler(this.btnRegisterStudent_Click);
            // 
            // btnStudentCourses
            // 
            this.btnStudentCourses.Location = new System.Drawing.Point(330, 12);
            this.btnStudentCourses.Name = "btnStudentCourses";
            this.btnStudentCourses.Size = new System.Drawing.Size(100, 50);
            this.btnStudentCourses.TabIndex = 3;
            this.btnStudentCourses.TabStop = false;
            this.btnStudentCourses.Text = "Student Courses";
            this.btnStudentCourses.UseVisualStyleBackColor = true;
            this.btnStudentCourses.Click += new System.EventHandler(this.btnStudentCourses_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 76);
            this.Controls.Add(this.btnStudentCourses);
            this.Controls.Add(this.btnRegisterStudent);
            this.Controls.Add(this.btnViewCourses);
            this.Controls.Add(this.btnCreateCourse);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Course Registration System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCourse;
        private System.Windows.Forms.Button btnViewCourses;
        private System.Windows.Forms.Button btnRegisterStudent;
        private System.Windows.Forms.Button btnStudentCourses;
    }
}