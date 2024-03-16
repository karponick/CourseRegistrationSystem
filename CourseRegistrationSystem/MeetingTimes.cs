using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistrationSystem
{
    internal class MeetingTimes : Panel
    {
        private readonly string[] LETTERS = { "M", "T", "W", "T", "F" };
        public MeetingTimes(bool[] days, string times)
        {
            // Colored square labels for day booleans
            Size = new Size(199, 39);
            BorderStyle = BorderStyle.None;

            Point point = new Point(5, 10);
            for (int i = 0; i < 5; i++)
            {
                Label lblDay = MakeSquare(days[i]);
                lblDay.Location = point;
                lblDay.Text = LETTERS[i];
                lblDay.TextAlign = ContentAlignment.MiddleCenter;
                point.X += 20;
                BackColor = Color.White;
                Controls.Add(lblDay);
            }

            // Label for time string
            Label lblTime = new Label
            {
                Text = times,
                Size = new Size(100, 20),
                Location = new Point(105, 15)
            };
            Controls.Add (lblTime);
        }

        /* 
         * Square Labels for MTWTF display
         * There is probably a better way to do this,
         * but this is the best i can think of right now without wasting too much time
        */
        private Label MakeSquare(bool isDay)
        {
            Label label = new Label
            {
                Size = new Size(20, 20),
                BorderStyle = BorderStyle.FixedSingle,
                AutoSize = false,
            };
            if (isDay) { label.BackColor = Color.PowderBlue; }
            else { label.BackColor = Color.White; }

            return label;
        }
    }
}
