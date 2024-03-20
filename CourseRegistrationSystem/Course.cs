using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private List<Course> prereqs;
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
            prereqs = new List<Course>();
            days = new[]{false, false, false, false, false};
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
        public void AddPrereq(Course prereq) { prereqs.Add(prereq); }
        public string TimeString() { return StartTime + "-" + EndTime; }
        public string CapacityString() 
        { 
            return SeatsAvail + " of " + seatsMax + " seats available."; 
        }
    }
}
