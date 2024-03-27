using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseRegistrationSystem
{
    internal class MeetingPanelV2 : Panel
    {
        private readonly Dictionary<bool, Color> boolColor = new Dictionary<bool, Color>()
            {{ true, Color.PowderBlue }, {false, Color.White }};
        private readonly string[] LETTERS = { "M", "T", "W", "T", "F" };
        public MeetingPanelV2(List<bool[]> daysList, List<string> timesList)
        {
            // Whole panel properties
            Size = new Size(199, 390);
            Location = new Point(304, 21);
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.None;

            for (int i = 0; i < daysList.Count; i++) // Loop over each course in list
            {
                int verticalOffset = 40 * i;
                // Day bool square label properties
                Point dayPoint = new Point(5, 10 + verticalOffset);
                for (int j = 0; j < 5; j++)
                {
                    Label lblDay = new Label
                    {
                        Size = new Size(20, 20),
                        Location = dayPoint,
                        BorderStyle = BorderStyle.FixedSingle,
                        AutoSize = false,
                        Text = LETTERS[j],
                        TextAlign = ContentAlignment.MiddleCenter,
                        BackColor = boolColor[daysList[i][j]],
                    };
                    dayPoint.X += 20;
                    Controls.Add(lblDay);
                }

                // Time string label properties
                Point timePoint = new Point(105, 15 + verticalOffset);
                for (int j = 0; j < timesList.Count; j++)
                {
                    Label lblTime = new Label
                    {
                        Size = new Size(100, 20),
                        Location = timePoint,
                        Text = timesList[j],
                    };
                    Controls.Add(lblTime);
                    timePoint.Y += 40;
                }
            }
            
            
        }
    }
}
