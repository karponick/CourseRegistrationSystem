﻿namespace CourseRegistrationSystem
{
    partial class frmCourseRoster
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
            this.dgvRoster = new System.Windows.Forms.DataGridView();
            this.lblCourse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoster)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoster
            // 
            this.dgvRoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoster.Location = new System.Drawing.Point(12, 29);
            this.dgvRoster.Name = "dgvRoster";
            this.dgvRoster.Size = new System.Drawing.Size(776, 409);
            this.dgvRoster.TabIndex = 0;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(13, 13);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(107, 13);
            this.lblCourse.TabIndex = 1;
            this.lblCourse.Text = "Course Name / Code";
            // 
            // frmCourseRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.dgvRoster);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCourseRoster";
            this.Text = "Course Roster";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoster;
        private System.Windows.Forms.Label lblCourse;
    }
}