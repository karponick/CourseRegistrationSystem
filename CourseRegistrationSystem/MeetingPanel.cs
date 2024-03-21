using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistrationSystem
{
    internal class MeetingPanel : Panel
    {
        private readonly static Dictionary<string, MeetingPanel> meetingPanelList = new Dictionary<string, MeetingPanel>();
        private readonly string[] LETTERS = { "M", "T", "W", "T", "F" };
        private readonly Label[] dayLabels = new Label[5];
        private readonly Label lblTime;

        public MeetingPanel()
        {
            Size = new Size(199, 39);
            BorderStyle = BorderStyle.None;
            BackColor = Color.White;
            Point point = new Point(5, 10);
            for (int i = 0; i < 5; i++)
            {
                Label lblDay = new Label
                {
                    Size = new Size(20, 20),
                    Location = point,
                    BorderStyle = BorderStyle.FixedSingle,
                    AutoSize = false,
                    Text = LETTERS[i],
                    TextAlign = ContentAlignment.MiddleCenter
                };
                point.X += 20;
                dayLabels[i] = lblDay;
                Controls.Add(lblDay);
            }
            // Label for time string
            lblTime = new Label
            {
                Size = new Size(100, 20),
                Location = new Point(105, 15)
            };
            Controls.Add(lblTime);
        }
        public void Populate(bool[] days, string times, string courseCode)
        {
            for (int i = 0; i < 5; i++)
            {
                if (days[i]) { dayLabels[i].BackColor = Color.PowderBlue; }
                else { dayLabels[i].BackColor = Color.White; }
            }
            lblTime.Text = times;
            if (courseCode != null) { meetingPanelList[courseCode] = this; }
        } 
        public static Dictionary<string, MeetingPanel> MeetingPanelList {  get { return meetingPanelList; } }
    }
}
