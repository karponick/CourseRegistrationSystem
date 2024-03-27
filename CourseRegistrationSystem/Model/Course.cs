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
        private string code;
        private string department;
        private string title;
        private string description;
        private string credits;
        private List<string> prereqs;
        private bool[] days;
        private string startTime;
        private string endTime;
        private string seatsMax;
        private string seatsAvail;
        private string professor;
        private string professorImgUrl;

        private readonly List<string> roster = new List<string>();

        // Constructor
        public Course()
        {
            days = new[]{false, false, false, false, false};
        }
        public Course(List<string> data)
        {
            code = data[0];
            department = data[1];
            title = data[2];
            description = data[3];
            credits = data[4];
            prereqs = data[5].Split(',').ToList();
            days = new[] { false, false, false, false, false };
            startTime = data[7];
            endTime = data[8];
            seatsMax = data[9];
            seatsAvail = data[10];
            professor = data[11];
            professorImgUrl = data[12];
            
            // Days
            for (int i = 0; i < 5; i++)
            {
                string dayString = data[6];
                if (dayString[i] == 'T') { Days[i] = true; }
            }
        }

        // Properties
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
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
        public List <string> Roster { get { return roster; } }

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
                if (Days[i]) { boolString += "T"; }
                else { boolString += "F"; }
            }
            return boolString;
        }
        public string TimeString() { return StartTime + "-" + EndTime; }
        public string CapacityString() 
        { 
            return SeatsAvail + " of " + seatsMax + " seats available."; 
        }
        public string[] ToArray()
        {
            string[] arr = new string[13];
            arr[0] = Code;
            arr[1] = Department;
            arr[2] = Title;
            arr[3] = Description;
            arr[4] = Credits;
            arr[5] = string.Join(",", Prereqs);
            arr[6] = DayBoolString();
            arr[7] = StartTime;
            arr[8] = EndTime;
            arr[9] = SeatsMax;
            arr[10] = SeatsAvail;
            arr[11] = Professor;
            arr[12] = ProfessorImgUrl;
            return arr;
        }
    }
}
