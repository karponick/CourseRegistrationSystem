using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistrationSystem
{
    internal class DetailPanel : Panel
    {
        // Fields
        private readonly Label lblCode, lblTitle, lblDescription, lblPrereqs, lblProfessor, lblCapacity, lblCredits;
        private readonly MeetingPanel meetingPanel;
        private readonly PictureBox picProfImg;
        private readonly Button btnClose, btnRoster;
        private readonly Form parentForm;
        readonly DatabaseControllerV2 dbc;

        // Constructor
        public DetailPanel(Form parentForm, DatabaseControllerV2 dbc)
        {
            Size = new Size(400, 370);
            Location = new Point(350, 33);//(312, 13),
            BackColor = Color.LightGray;
            BorderStyle = BorderStyle.FixedSingle;
            Visible = false;
            this.parentForm = parentForm;
            this.dbc = dbc;
            // PANEL IS 400x370

            // All controls for details within details panel
            lblCode = new Label
            {
                Size = new Size(100, 40),
                Location = new Point(10, 10),
            };

            lblTitle = new Label
            {
                Size = new Size(270, 40),
                Location = new Point(120, 10),
            };

            lblDescription = new Label
            {
                Size = new Size(380, 90),
                Location = new Point(10, 60),
            };

            lblPrereqs = new Label
            {
                Size = new Size(380, 20),
                Location = new Point(10, 160)
            };

            meetingPanel = new MeetingPanel()
            {
                Location = new Point(10, 190),
                BorderStyle = BorderStyle.FixedSingle
            };

            lblProfessor = new Label
            {
                Size = new Size(199, 40),
                Location = new Point(10, 240),
            };

            picProfImg = new PictureBox
            {
                Size = new Size(170, 170),
                Location = new Point(220, 190),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White
            };

            lblCapacity = new Label
            {
                Size = new Size(95, 40),
                Location = new Point(10, 290),
            };

            lblCredits = new Label
            {
                Size = new Size(94, 40),
                Location = new Point(115, 290),
            };

            btnClose = new Button
            {
                Text = "Close",
                Size = new Size(94, 20),
                Location = new Point(10, 340),
                BackColor = Color.LightBlue
            };
            btnClose.Click += btnClose_Click;

            btnRoster = new Button
            {
                Text = "Roster",
                Size = new Size(95, 20),
                Location = new Point(115, 340),
                BackColor = Color.Yellow
            };
            btnRoster.Click += btnRoster_Click;

            // Add all controls to panel
            Controls.Add(lblCode);
            Controls.Add(lblTitle);
            Controls.Add(lblDescription);
            Controls.Add(lblPrereqs);
            Controls.Add(meetingPanel);
            Controls.Add(lblProfessor);
            Controls.Add(picProfImg);
            Controls.Add(lblCapacity);
            Controls.Add(lblCredits);
            Controls.Add(btnClose);
            Controls.Add(btnRoster);

            // label properties
            foreach (Label label in Controls.OfType<Label>())
            {
                label.BorderStyle = BorderStyle.FixedSingle;
                label.BackColor = Color.White;
                label.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        public void Populate(Course course)
        {
            // PANEL IS 400x370

            // All controls for details within details panel
            lblCode.Text = course.Code;
            lblTitle.Text = course.Title;
            lblDescription.Text = course.Description;
            lblPrereqs.Text = string.Join(", ", course.Prereqs);
            meetingPanel.Populate(course.Days, course.TimeString(), null);
            lblProfessor.Text = course.Professor;
            try { picProfImg.Load(course.ProfessorImgUrl); }
            catch (Exception) 
            { 
                Console.WriteLine("Image could not be loaded.");
                picProfImg.Image = null;
            }
            lblCapacity.Text = course.CapacityString();
            lblCredits.Text = course.Credits + " credits";

            foreach (Control control in Controls)
            {
                control.Visible = true;
            }
            // Make course detail panel visible
            Visible = true;
            BringToFront();
        }

        public void HideDetails()
        {
            foreach (Control control in Controls)
            {
                control.Visible = false;
            }
            Visible = false;
        }

        // Events
        public void btnClose_Click(object sender, EventArgs e)
        {
            frmCourseListing parent = parentForm as frmCourseListing;
            parent.CloseDetailPanel();
        }
        public void btnRoster_Click(object sender, EventArgs e)
        {
            frmStudentList studentList = new frmStudentList(dbc.GetCourseRoster(lblCode.Text));
            studentList.Owner = null;
            studentList.ShowDialog();
        }
    }
}
