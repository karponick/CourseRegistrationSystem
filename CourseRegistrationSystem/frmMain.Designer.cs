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
            this.comboDepartment.Location = new System.Drawing.Point(106, 6);
            this.comboDepartment.Name = "comboDepartment";
            this.comboDepartment.Size = new System.Drawing.Size(185, 21);
            this.comboDepartment.TabIndex = 0;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(106, 33);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(185, 20);
            this.txtCode.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(105, 59);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(185, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(105, 85);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(185, 125);
            this.txtDescription.TabIndex = 3;
            // 
            // comboPrereqs
            // 
            this.comboPrereqs.FormattingEnabled = true;
            this.comboPrereqs.Location = new System.Drawing.Point(104, 243);
            this.comboPrereqs.Name = "comboPrereqs";
            this.comboPrereqs.Size = new System.Drawing.Size(185, 21);
            this.comboPrereqs.TabIndex = 5;
            this.comboPrereqs.Text = "Prereqs";
            // 
            // flowDays
            // 
            this.flowDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowDays.Controls.Add(this.chkMon);
            this.flowDays.Controls.Add(this.chkTues);
            this.flowDays.Controls.Add(this.chkWed);
            this.flowDays.Controls.Add(this.chkThurs);
            this.flowDays.Controls.Add(this.chkFri);
            this.flowDays.Location = new System.Drawing.Point(317, 276);
            this.flowDays.Name = "flowDays";
            this.flowDays.Size = new System.Drawing.Size(295, 42);
            this.flowDays.TabIndex = 6;
            // 
            // chkMon
            // 
            this.chkMon.AutoSize = true;
            this.chkMon.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkMon.Location = new System.Drawing.Point(3, 3);
            this.chkMon.Name = "chkMon";
            this.chkMon.Size = new System.Drawing.Size(49, 31);
            this.chkMon.TabIndex = 0;
            this.chkMon.Text = "Monday";
            this.chkMon.UseVisualStyleBackColor = true;
            // 
            // chkTues
            // 
            this.chkTues.AutoSize = true;
            this.chkTues.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkTues.Location = new System.Drawing.Point(58, 3);
            this.chkTues.Name = "chkTues";
            this.chkTues.Size = new System.Drawing.Size(52, 31);
            this.chkTues.TabIndex = 1;
            this.chkTues.Text = "Tuesday";
            this.chkTues.UseVisualStyleBackColor = true;
            // 
            // chkWed
            // 
            this.chkWed.AutoSize = true;
            this.chkWed.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkWed.Location = new System.Drawing.Point(116, 3);
            this.chkWed.Name = "chkWed";
            this.chkWed.Size = new System.Drawing.Size(68, 31);
            this.chkWed.TabIndex = 2;
            this.chkWed.Text = "Wednesday";
            this.chkWed.UseVisualStyleBackColor = true;
            // 
            // chkThurs
            // 
            this.chkThurs.AutoSize = true;
            this.chkThurs.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkThurs.Location = new System.Drawing.Point(190, 3);
            this.chkThurs.Name = "chkThurs";
            this.chkThurs.Size = new System.Drawing.Size(55, 31);
            this.chkThurs.TabIndex = 3;
            this.chkThurs.Text = "Thursday";
            this.chkThurs.UseVisualStyleBackColor = true;
            // 
            // chkFri
            // 
            this.chkFri.AutoSize = true;
            this.chkFri.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkFri.Location = new System.Drawing.Point(251, 3);
            this.chkFri.Name = "chkFri";
            this.chkFri.Size = new System.Drawing.Size(39, 31);
            this.chkFri.TabIndex = 4;
            this.chkFri.Text = "Friday";
            this.chkFri.UseVisualStyleBackColor = true;
            // 
            // txtTimeStart
            // 
            this.txtTimeStart.Location = new System.Drawing.Point(104, 324);
            this.txtTimeStart.Name = "txtTimeStart";
            this.txtTimeStart.Size = new System.Drawing.Size(185, 20);
            this.txtTimeStart.TabIndex = 7;
            // 
            // txtSeatsMax
            // 
            this.txtSeatsMax.Location = new System.Drawing.Point(104, 270);
            this.txtSeatsMax.Name = "txtSeatsMax";
            this.txtSeatsMax.Size = new System.Drawing.Size(185, 20);
            this.txtSeatsMax.TabIndex = 8;
            this.txtSeatsMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            // 
            // txtSeatsAvail
            // 
            this.txtSeatsAvail.Location = new System.Drawing.Point(104, 297);
            this.txtSeatsAvail.Name = "txtSeatsAvail";
            this.txtSeatsAvail.Size = new System.Drawing.Size(185, 20);
            this.txtSeatsAvail.TabIndex = 9;
            this.txtSeatsAvail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            // 
            // txtProf
            // 
            this.txtProf.Location = new System.Drawing.Point(430, 31);
            this.txtProf.Name = "txtProf";
            this.txtProf.Size = new System.Drawing.Size(185, 20);
            this.txtProf.TabIndex = 10;
            // 
            // txtProfImgUrl
            // 
            this.txtProfImgUrl.Location = new System.Drawing.Point(430, 58);
            this.txtProfImgUrl.Name = "txtProfImgUrl";
            this.txtProfImgUrl.Size = new System.Drawing.Size(185, 20);
            this.txtProfImgUrl.TabIndex = 11;
            this.txtProfImgUrl.TextChanged += new System.EventHandler(this.txtProfImgUrl_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(419, 386);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(193, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnViewList
            // 
            this.btnViewList.Location = new System.Drawing.Point(15, 386);
            this.btnViewList.Name = "btnViewList";
            this.btnViewList.Size = new System.Drawing.Size(118, 23);
            this.btnViewList.TabIndex = 13;
            this.btnViewList.Text = "View Course List";
            this.btnViewList.UseVisualStyleBackColor = true;
            this.btnViewList.Click += new System.EventHandler(this.btnViewList_Click);
            // 
            // txtTimeEnd
            // 
            this.txtTimeEnd.Location = new System.Drawing.Point(104, 350);
            this.txtTimeEnd.Name = "txtTimeEnd";
            this.txtTimeEnd.Size = new System.Drawing.Size(185, 20);
            this.txtTimeEnd.TabIndex = 14;
            // 
            // picProf
            // 
            this.picProf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProf.Location = new System.Drawing.Point(430, 87);
            this.picProf.Name = "picProf";
            this.picProf.Size = new System.Drawing.Size(182, 182);
            this.picProf.TabIndex = 15;
            this.picProf.TabStop = false;
            // 
            // lblDep
            // 
            this.lblDep.Location = new System.Drawing.Point(12, 9);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(87, 13);
            this.lblDep.TabIndex = 16;
            this.lblDep.Text = "Department";
            this.lblDep.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(12, 35);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(87, 13);
            this.lblCode.TabIndex = 17;
            this.lblCode.Text = "Code";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(12, 61);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(87, 13);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDesc
            // 
            this.lblDesc.Location = new System.Drawing.Point(12, 87);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(87, 13);
            this.lblDesc.TabIndex = 19;
            this.lblDesc.Text = "Description";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCred
            // 
            this.lblCred.Location = new System.Drawing.Point(12, 219);
            this.lblCred.Name = "lblCred";
            this.lblCred.Size = new System.Drawing.Size(87, 13);
            this.lblCred.TabIndex = 20;
            this.lblCred.Text = "Credits";
            this.lblCred.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrereq
            // 
            this.lblPrereq.Location = new System.Drawing.Point(12, 246);
            this.lblPrereq.Name = "lblPrereq";
            this.lblPrereq.Size = new System.Drawing.Size(87, 13);
            this.lblPrereq.TabIndex = 21;
            this.lblPrereq.Text = "Prerequisites";
            this.lblPrereq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStartTime
            // 
            this.lblStartTime.Location = new System.Drawing.Point(11, 326);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(87, 13);
            this.lblStartTime.TabIndex = 22;
            this.lblStartTime.Text = "Start Time";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEndTime
            // 
            this.lblEndTime.Location = new System.Drawing.Point(11, 352);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(87, 13);
            this.lblEndTime.TabIndex = 23;
            this.lblEndTime.Text = "End Time";
            this.lblEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSeatsMax
            // 
            this.lblSeatsMax.Location = new System.Drawing.Point(11, 272);
            this.lblSeatsMax.Name = "lblSeatsMax";
            this.lblSeatsMax.Size = new System.Drawing.Size(87, 13);
            this.lblSeatsMax.TabIndex = 24;
            this.lblSeatsMax.Text = "Max Seats";
            this.lblSeatsMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSeatsAvail
            // 
            this.lblSeatsAvail.Location = new System.Drawing.Point(11, 299);
            this.lblSeatsAvail.Name = "lblSeatsAvail";
            this.lblSeatsAvail.Size = new System.Drawing.Size(87, 13);
            this.lblSeatsAvail.TabIndex = 25;
            this.lblSeatsAvail.Text = "Seats Available";
            this.lblSeatsAvail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProf
            // 
            this.lblProf.Location = new System.Drawing.Point(293, 33);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(130, 13);
            this.lblProf.TabIndex = 26;
            this.lblProf.Text = "Professor";
            this.lblProf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProfImgUrl
            // 
            this.lblProfImgUrl.Location = new System.Drawing.Point(293, 60);
            this.lblProfImgUrl.Name = "lblProfImgUrl";
            this.lblProfImgUrl.Size = new System.Drawing.Size(130, 13);
            this.lblProfImgUrl.TabIndex = 27;
            this.lblProfImgUrl.Text = "URL for Professor Image";
            this.lblProfImgUrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(317, 252);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(59, 13);
            this.lblDays.TabIndex = 28;
            this.lblDays.Text = "Class Days";
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(105, 217);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(185, 20);
            this.txtCredits.TabIndex = 29;
            this.txtCredits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric_KeyPress);
            // 
            // lblStatus
            // 
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(381, 357);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(231, 13);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.Text = "Error: Course with this code already exists in list.";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblStatus.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(317, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear Data";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnValidation
            // 
            this.btnValidation.BackColor = System.Drawing.Color.LightPink;
            this.btnValidation.Location = new System.Drawing.Point(159, 385);
            this.btnValidation.Name = "btnValidation";
            this.btnValidation.Size = new System.Drawing.Size(130, 23);
            this.btnValidation.TabIndex = 32;
            this.btnValidation.Text = "Toggle Validation";
            this.btnValidation.UseVisualStyleBackColor = false;
            this.btnValidation.Click += new System.EventHandler(this.btnValidation_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 420);
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
    }
}

