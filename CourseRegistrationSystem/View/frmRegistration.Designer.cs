namespace CourseRegistrationSystem
{
    partial class frmRegistration
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.lstCourses = new System.Windows.Forms.ListView();
            this.hdrCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrDays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrTimes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrProf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblCost = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Student ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Full Name";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(19, 61);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(51, 13);
            this.lblSemester.TabIndex = 2;
            this.lblSemester.Text = "Semester";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(12, 85);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(246, 23);
            this.btnView.TabIndex = 3;
            this.btnView.TabStop = false;
            this.btnView.Text = "View Courses";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 143);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(246, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 114);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(246, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(76, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(182, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(76, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 1;
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            "Fall",
            "Spring",
            "Summer I",
            "Summer II"});
            this.cmbSemester.Location = new System.Drawing.Point(76, 58);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(182, 21);
            this.cmbSemester.TabIndex = 2;
            // 
            // lstCourses
            // 
            this.lstCourses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCourses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrCode,
            this.hdrDays,
            this.hdrTimes,
            this.hdrProf});
            this.lstCourses.FullRowSelect = true;
            this.lstCourses.GridLines = true;
            this.lstCourses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstCourses.HideSelection = false;
            this.lstCourses.Location = new System.Drawing.Point(264, 6);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(655, 131);
            this.lstCourses.TabIndex = 9;
            this.lstCourses.UseCompatibleStateImageBehavior = false;
            this.lstCourses.View = System.Windows.Forms.View.Details;
            this.lstCourses.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstCourses_ItemSelectionChanged);
            // 
            // hdrCode
            // 
            this.hdrCode.Text = "Code";
            this.hdrCode.Width = 100;
            // 
            // hdrDays
            // 
            this.hdrDays.Text = "Days";
            this.hdrDays.Width = 245;
            // 
            // hdrTimes
            // 
            this.hdrTimes.Text = "Times";
            this.hdrTimes.Width = 150;
            // 
            // hdrProf
            // 
            this.hdrProf.Text = "Professor";
            this.hdrProf.Width = 135;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(264, 148);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(95, 13);
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "$700 / Credit Hour";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(766, 143);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(153, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove Course";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 174);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistration";
            this.Text = "Student Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.ListView lstCourses;
        private System.Windows.Forms.ColumnHeader hdrCode;
        private System.Windows.Forms.ColumnHeader hdrDays;
        private System.Windows.Forms.ColumnHeader hdrTimes;
        private System.Windows.Forms.ColumnHeader hdrProf;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnRemove;
    }
}