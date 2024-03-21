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
            this.comboDepartment = new System.Windows.Forms.ComboBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.comboPrereqs = new System.Windows.Forms.ComboBox();
            this.flowDays = new System.Windows.Forms.FlowLayoutPanel();
            this.chkMon = new System.Windows.Forms.CheckBox();
            this.chkTues = new System.Windows.Forms.CheckBox();
            this.chkWed = new System.Windows.Forms.CheckBox();
            this.chkThurs = new System.Windows.Forms.CheckBox();
            this.chkFri = new System.Windows.Forms.CheckBox();
            this.txtTimeStart = new System.Windows.Forms.TextBox();
            this.txtSeatsMax = new System.Windows.Forms.TextBox();
            this.txtSeatsAvail = new System.Windows.Forms.TextBox();
            this.txtProf = new System.Windows.Forms.TextBox();
            this.txtProfImgUrl = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnViewList = new System.Windows.Forms.Button();
            this.txtTimeEnd = new System.Windows.Forms.TextBox();
            this.picProf = new System.Windows.Forms.PictureBox();
            this.lblDep = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCred = new System.Windows.Forms.Label();
            this.lblPrereq = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblSeatsMax = new System.Windows.Forms.Label();
            this.lblSeatsAvail = new System.Windows.Forms.Label();
            this.lblProf = new System.Windows.Forms.Label();
            this.lblProfImgUrl = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnValidation = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstPrereqs = new System.Windows.Forms.ListView();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.flowDays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProf)).BeginInit();
            this.SuspendLayout();
            // 
            // comboDepartment
            // 
            this.comboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDepartment.FormattingEnabled = true;
            this.comboDepartment.Items.AddRange(new object[] {
            "CIS",
            "CHE",
            "MAT",
            "BUS",
            "BIO"});
            this.comboDepartment.Location = new System.Drawing.Point(82, 6);
            this.comboDepartment.Name = "comboDepartment";
            this.comboDepartment.Size = new System.Drawing.Size(111, 21);
            this.comboDepartment.TabIndex = 0;
            this.comboDepartment.TabStop = false;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(266, 7);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(111, 20);
            this.txtCode.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(82, 35);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(295, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(82, 61);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(295, 128);
            this.txtDescription.TabIndex = 3;
            // 
            // comboPrereqs
            // 
            this.comboPrereqs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrereqs.FormattingEnabled = true;
            this.comboPrereqs.Location = new System.Drawing.Point(83, 249);
            this.comboPrereqs.Name = "comboPrereqs";
            this.comboPrereqs.Size = new System.Drawing.Size(252, 21);
            this.comboPrereqs.TabIndex = 5;
            // 
            // flowDays
            // 
            this.flowDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowDays.Controls.Add(this.chkMon);
            this.flowDays.Controls.Add(this.chkTues);
            this.flowDays.Controls.Add(this.chkWed);
            this.flowDays.Controls.Add(this.chkThurs);
            this.flowDays.Controls.Add(this.chkFri);
            this.flowDays.Location = new System.Drawing.Point(82, 359);
            this.flowDays.Name = "flowDays";
            this.flowDays.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.flowDays.Size = new System.Drawing.Size(295, 46);
            this.flowDays.TabIndex = 6;
            // 
            // chkMon
            // 
            this.chkMon.AutoSize = true;
            this.chkMon.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkMon.Location = new System.Drawing.Point(3, 8);
            this.chkMon.Name = "chkMon";
            this.chkMon.Size = new System.Drawing.Size(49, 31);
            this.chkMon.TabIndex = 0;
            this.chkMon.TabStop = false;
            this.chkMon.Text = "Monday";
            this.chkMon.UseVisualStyleBackColor = true;
            // 
            // chkTues
            // 
            this.chkTues.AutoSize = true;
            this.chkTues.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkTues.Location = new System.Drawing.Point(58, 8);
            this.chkTues.Name = "chkTues";
            this.chkTues.Size = new System.Drawing.Size(52, 31);
            this.chkTues.TabIndex = 1;
            this.chkTues.TabStop = false;
            this.chkTues.Text = "Tuesday";
            this.chkTues.UseVisualStyleBackColor = true;
            // 
            // chkWed
            // 
            this.chkWed.AutoSize = true;
            this.chkWed.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkWed.Location = new System.Drawing.Point(116, 8);
            this.chkWed.Name = "chkWed";
            this.chkWed.Size = new System.Drawing.Size(68, 31);
            this.chkWed.TabIndex = 2;
            this.chkWed.TabStop = false;
            this.chkWed.Text = "Wednesday";
            this.chkWed.UseVisualStyleBackColor = true;
            // 
            // chkThurs
            // 
            this.chkThurs.AutoSize = true;
            this.chkThurs.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkThurs.Location = new System.Drawing.Point(190, 8);
            this.chkThurs.Name = "chkThurs";
            this.chkThurs.Size = new System.Drawing.Size(55, 31);
            this.chkThurs.TabIndex = 3;
            this.chkThurs.TabStop = false;
            this.chkThurs.Text = "Thursday";
            this.chkThurs.UseVisualStyleBackColor = true;
            // 
            // chkFri
            // 
            this.chkFri.AutoSize = true;
            this.chkFri.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkFri.Location = new System.Drawing.Point(251, 8);
            this.chkFri.Name = "chkFri";
            this.chkFri.Size = new System.Drawing.Size(39, 31);
            this.chkFri.TabIndex = 4;
            this.chkFri.TabStop = false;
            this.chkFri.Text = "Friday";
            this.chkFri.UseVisualStyleBackColor = true;
            // 
            // txtTimeStart
            // 
            this.txtTimeStart.Location = new System.Drawing.Point(82, 222);
            this.txtTimeStart.Name = "txtTimeStart";
            this.txtTimeStart.Size = new System.Drawing.Size(111, 20);
            this.txtTimeStart.TabIndex = 7;
            // 
            // txtSeatsMax
            // 
            this.txtSeatsMax.Location = new System.Drawing.Point(205, 195);
            this.txtSeatsMax.Name = "txtSeatsMax";
            this.txtSeatsMax.Size = new System.Drawing.Size(31, 20);
            this.txtSeatsMax.TabIndex = 5;
            this.txtSeatsMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            // 
            // txtSeatsAvail
            // 
            this.txtSeatsAvail.Location = new System.Drawing.Point(346, 195);
            this.txtSeatsAvail.Name = "txtSeatsAvail";
            this.txtSeatsAvail.Size = new System.Drawing.Size(31, 20);
            this.txtSeatsAvail.TabIndex = 6;
            this.txtSeatsAvail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            // 
            // txtProf
            // 
            this.txtProf.Location = new System.Drawing.Point(82, 416);
            this.txtProf.Name = "txtProf";
            this.txtProf.Size = new System.Drawing.Size(295, 20);
            this.txtProf.TabIndex = 10;
            // 
            // txtProfImgUrl
            // 
            this.txtProfImgUrl.Location = new System.Drawing.Point(82, 450);
            this.txtProfImgUrl.Name = "txtProfImgUrl";
            this.txtProfImgUrl.Size = new System.Drawing.Size(295, 20);
            this.txtProfImgUrl.TabIndex = 11;
            this.txtProfImgUrl.TextChanged += new System.EventHandler(this.txtProfImgUrl_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(383, 301);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(182, 49);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.TabStop = false;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnViewList
            // 
            this.btnViewList.Location = new System.Drawing.Point(383, 411);
            this.btnViewList.Name = "btnViewList";
            this.btnViewList.Size = new System.Drawing.Size(182, 28);
            this.btnViewList.TabIndex = 13;
            this.btnViewList.TabStop = false;
            this.btnViewList.Text = "View Courses";
            this.btnViewList.UseVisualStyleBackColor = true;
            this.btnViewList.Click += new System.EventHandler(this.btnViewList_Click);
            // 
            // txtTimeEnd
            // 
            this.txtTimeEnd.Location = new System.Drawing.Point(266, 221);
            this.txtTimeEnd.Name = "txtTimeEnd";
            this.txtTimeEnd.Size = new System.Drawing.Size(111, 20);
            this.txtTimeEnd.TabIndex = 8;
            // 
            // picProf
            // 
            this.picProf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProf.Location = new System.Drawing.Point(383, 7);
            this.picProf.Name = "picProf";
            this.picProf.Size = new System.Drawing.Size(182, 182);
            this.picProf.TabIndex = 15;
            this.picProf.TabStop = false;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(16, 10);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(62, 13);
            this.lblDep.TabIndex = 16;
            this.lblDep.Text = "Department";
            this.lblDep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(217, 10);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(45, 13);
            this.lblCode.TabIndex = 17;
            this.lblCode.Text = "Code";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(49, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(16, 61);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 19;
            this.lblDesc.Text = "Description";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCred
            // 
            this.lblCred.AutoSize = true;
            this.lblCred.Location = new System.Drawing.Point(37, 198);
            this.lblCred.Name = "lblCred";
            this.lblCred.Size = new System.Drawing.Size(39, 13);
            this.lblCred.TabIndex = 20;
            this.lblCred.Text = "Credits";
            this.lblCred.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrereq
            // 
            this.lblPrereq.AutoSize = true;
            this.lblPrereq.Location = new System.Drawing.Point(10, 252);
            this.lblPrereq.Name = "lblPrereq";
            this.lblPrereq.Size = new System.Drawing.Size(67, 13);
            this.lblPrereq.TabIndex = 21;
            this.lblPrereq.Text = "Prerequisites";
            this.lblPrereq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(23, 225);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(55, 13);
            this.lblStartTime.TabIndex = 22;
            this.lblStartTime.Text = "Start Time";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEndTime
            // 
            this.lblEndTime.Location = new System.Drawing.Point(202, 225);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(60, 13);
            this.lblEndTime.TabIndex = 23;
            this.lblEndTime.Text = "End Time";
            this.lblEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSeatsMax
            // 
            this.lblSeatsMax.Location = new System.Drawing.Point(140, 198);
            this.lblSeatsMax.Name = "lblSeatsMax";
            this.lblSeatsMax.Size = new System.Drawing.Size(59, 13);
            this.lblSeatsMax.TabIndex = 24;
            this.lblSeatsMax.Text = "Max Seats";
            this.lblSeatsMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSeatsAvail
            // 
            this.lblSeatsAvail.Location = new System.Drawing.Point(260, 198);
            this.lblSeatsAvail.Name = "lblSeatsAvail";
            this.lblSeatsAvail.Size = new System.Drawing.Size(80, 13);
            this.lblSeatsAvail.TabIndex = 25;
            this.lblSeatsAvail.Text = "Seats Available";
            this.lblSeatsAvail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Location = new System.Drawing.Point(25, 419);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(51, 13);
            this.lblProf.TabIndex = 26;
            this.lblProf.Text = "Professor";
            this.lblProf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProfImgUrl
            // 
            this.lblProfImgUrl.AutoSize = true;
            this.lblProfImgUrl.Location = new System.Drawing.Point(15, 453);
            this.lblProfImgUrl.Name = "lblProfImgUrl";
            this.lblProfImgUrl.Size = new System.Drawing.Size(61, 13);
            this.lblProfImgUrl.TabIndex = 27;
            this.lblProfImgUrl.Text = "Image URL";
            this.lblProfImgUrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(19, 376);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(59, 13);
            this.lblDays.TabIndex = 28;
            this.lblDays.Text = "Class Days";
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(82, 195);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(31, 20);
            this.txtCredits.TabIndex = 4;
            this.txtCredits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(383, 359);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(182, 46);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(383, 195);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(182, 47);
            this.btnClear.TabIndex = 31;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnValidation
            // 
            this.btnValidation.BackColor = System.Drawing.Color.LightPink;
            this.btnValidation.Location = new System.Drawing.Point(383, 248);
            this.btnValidation.Name = "btnValidation";
            this.btnValidation.Size = new System.Drawing.Size(182, 47);
            this.btnValidation.TabIndex = 32;
            this.btnValidation.TabStop = false;
            this.btnValidation.Text = "Toggle Validation";
            this.btnValidation.UseVisualStyleBackColor = false;
            this.btnValidation.Click += new System.EventHandler(this.btnValidation_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(341, 247);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 23);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstPrereqs
            // 
            this.lstPrereqs.GridLines = true;
            this.lstPrereqs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstPrereqs.HideSelection = false;
            this.lstPrereqs.Location = new System.Drawing.Point(82, 278);
            this.lstPrereqs.MultiSelect = false;
            this.lstPrereqs.Name = "lstPrereqs";
            this.lstPrereqs.Size = new System.Drawing.Size(295, 72);
            this.lstPrereqs.TabIndex = 9;
            this.lstPrereqs.UseCompatibleStateImageBehavior = false;
            this.lstPrereqs.View = System.Windows.Forms.View.List;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(383, 445);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(182, 28);
            this.btnRegistration.TabIndex = 34;
            this.btnRegistration.Text = "Student Registration";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 478);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.lstPrereqs);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnValidation);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtCredits);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblProfImgUrl);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.lblSeatsAvail);
            this.Controls.Add(this.lblSeatsMax);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblPrereq);
            this.Controls.Add(this.lblCred);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.picProf);
            this.Controls.Add(this.txtTimeEnd);
            this.Controls.Add(this.btnViewList);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtProfImgUrl);
            this.Controls.Add(this.txtProf);
            this.Controls.Add(this.txtSeatsAvail);
            this.Controls.Add(this.txtSeatsMax);
            this.Controls.Add(this.txtTimeStart);
            this.Controls.Add(this.flowDays);
            this.Controls.Add(this.comboPrereqs);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.comboDepartment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "CourseRegistrationSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.flowDays.ResumeLayout(false);
            this.flowDays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboDepartment;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox comboPrereqs;
        private System.Windows.Forms.FlowLayoutPanel flowDays;
        private System.Windows.Forms.CheckBox chkMon;
        private System.Windows.Forms.CheckBox chkTues;
        private System.Windows.Forms.CheckBox chkWed;
        private System.Windows.Forms.CheckBox chkThurs;
        private System.Windows.Forms.CheckBox chkFri;
        private System.Windows.Forms.TextBox txtTimeStart;
        private System.Windows.Forms.TextBox txtSeatsMax;
        private System.Windows.Forms.TextBox txtSeatsAvail;
        private System.Windows.Forms.TextBox txtProf;
        private System.Windows.Forms.TextBox txtProfImgUrl;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnViewList;
        private System.Windows.Forms.TextBox txtTimeEnd;
        private System.Windows.Forms.PictureBox picProf;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCred;
        private System.Windows.Forms.Label lblPrereq;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblSeatsMax;
        private System.Windows.Forms.Label lblSeatsAvail;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.Label lblProfImgUrl;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnValidation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lstPrereqs;
        private System.Windows.Forms.Button btnRegistration;
    }
}

