using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CourseRegistrationSystem
{
    public class Course
    {
        // Fields
        private string department;
        private string code;
        private string title;
        private string description;
        private string credits;
        private List<String> prereqs;
        private bool[] days;
        private string startTime;
        private string endTime;
        private string seatsMax;
        private string seatsAvail;
        private string professor;
        private string professorImgUrl;

        // Constructor
        public Course()
        {
            days = new[]{false, false, false, false, false};
            department = string.Empty;
        }

        // Properties
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Credits
        {
            get { return credits; }
            set { credits = value; }
        }
        public List<string> Prereqs
        {
            get { return prereqs; }
            set { prereqs = value; }
        }
        public bool[] Days
        {
            get { return days; }
            set { days = value; }
        }
        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }
        public string EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
        public string SeatsMax
        {
            get { return seatsMax; }
            set { seatsMax = value; }
        }
        public string SeatsAvail
        {
            get { return seatsAvail; }
            set { seatsAvail = value; }
        }
        public string Professor
        {
            get { return professor; }
            set { professor = value; }
        }
        public string ProfessorImgUrl
        {
            get { return professorImgUrl; }
            set { professorImgUrl = value; }
        }

        // Methods
        public string DayString()
        {
            string[] arrDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            string dayString = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                if (Days[i])
                {
                    dayString += arrDays[i];
                    if (i != 4)
                    {
                        dayString += ", ";
                    }
                }
            }
            return dayString;
        }
        public string DayBoolString()
        {
            string boolString = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                if (Days[i]) { boolString += Title; }
                else { boolString += "F"; }
            }
            return boolString;
        }
        public string TimeString() { return StartTime + "-" + EndTime; }
        public string CapacityString() 
        { 
            return SeatsAvail + " of " + seatsMax + " seats available."; 
        }
        public string[] OutputArr()
        {
            string[] arr = new string[14];
            arr[0] = Code;
            arr[1] = Department;
            arr[2] = Code;
            arr[3] = Title;
            arr[4] = Description;
            arr[5] = Credits;
            arr[6] = string.Join(",", Prereqs);
            arr[7] = DayBoolString();
            arr[8] = StartTime;
            arr[9] = EndTime;
            arr[10] = SeatsMax;
            arr[11] = SeatsAvail;
            arr[12] = Professor;
            arr[13] = ProfessorImgUrl;
            return arr;
        }
    }
}
