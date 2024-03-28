namespace CourseRegistrationSystem
{
    partial class frmCourseListing
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
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingTimes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblShowing = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAddtoReg = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.AllowUserToResizeColumns = false;
            this.dgvCourses.AllowUserToResizeRows = false;
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCourses.BackgroundColor = System.Drawing.Color.White;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.title,
            this.meetingTimes,
            this.capacity,
            this.professor});
            this.dgvCourses.Location = new System.Drawing.Point(12, 12);
            this.dgvCourses.MultiSelect = false;
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(800, 422);
            this.dgvCourses.TabIndex = 2;
            this.dgvCourses.TabStop = false;
            this.dgvCourses.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvCourses_RowStateChanged);
            // 
            // code
            // 
            this.code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.code.HeaderText = "Code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.title.Width = 200;
            // 
            // meetingTimes
            // 
            this.meetingTimes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.meetingTimes.HeaderText = "Meeting Times";
            this.meetingTimes.Name = "meetingTimes";
            this.meetingTimes.ReadOnly = true;
            this.meetingTimes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.meetingTimes.Width = 200;
            // 
            // capacity
            // 
            this.capacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.capacity.HeaderText = "Capacity";
            this.capacity.Name = "capacity";
            this.capacity.ReadOnly = true;
            this.capacity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // professor
            // 
            this.professor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.professor.HeaderText = "Professor";
            this.professor.Name = "professor";
            this.professor.ReadOnly = true;
            this.professor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.professor.Width = 200;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(818, 12);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(61, 13);
            this.lblFilter.TabIndex = 3;
            this.lblFilter.Text = "Search by :";
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Items.AddRange(new object[] {
            "Code",
            "Department",
            "Title",
            "Professor"});
            this.cmbFilter.Location = new System.Drawing.Point(818, 28);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(123, 21);
            this.cmbFilter.TabIndex = 4;
            this.cmbFilter.TabStop = false;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(818, 81);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(123, 20);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.TabStop = false;
            this.btnFilter.Text = "Clear Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Enabled = false;
            this.btnPrev.Location = new System.Drawing.Point(818, 376);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(123, 25);
            this.btnPrev.TabIndex = 6;
            this.btnPrev.TabStop = false;
            this.btnPrev.Text = "Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(818, 406);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(123, 25);
            this.btnNext.TabIndex = 7;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblShowing
            // 
            this.lblShowing.Location = new System.Drawing.Point(818, 350);
            this.lblShowing.Name = "lblShowing";
            this.lblShowing.Size = new System.Drawing.Size(123, 20);
            this.lblShowing.TabIndex = 8;
            this.lblShowing.Text = "Page 1";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(818, 144);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(123, 45);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.TabStop = false;
            this.btnCreate.Text = "Create Course";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Visible = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(818, 198);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(123, 45);
            this.btnModify.TabIndex = 10;
            this.btnModify.TabStop = false;
            this.btnModify.Text = "Modify Course";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Visible = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAddtoReg
            // 
            this.btnAddtoReg.Location = new System.Drawing.Point(818, 144);
            this.btnAddtoReg.Name = "btnAddtoReg";
            this.btnAddtoReg.Size = new System.Drawing.Size(123, 45);
            this.btnAddtoReg.TabIndex = 11;
            this.btnAddtoReg.TabStop = false;
            this.btnAddtoReg.Text = "Add Selected Course to Registration";
            this.btnAddtoReg.UseVisualStyleBackColor = true;
            this.btnAddtoReg.Visible = false;
            this.btnAddtoReg.Click += new System.EventHandler(this.btnAddtoReg_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightPink;
            this.btnDelete.Location = new System.Drawing.Point(818, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 45);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Delete Course";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(818, 55);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(123, 20);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TabStop = false;
            // 
            // frmCourseListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 441);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddtoReg);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblShowing);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.dgvCourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCourseListing";
            this.Text = "Course Listing";
            this.Load += new System.EventHandler(this.frmCourseListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn professor;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblShowing;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAddtoReg;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
    }
}