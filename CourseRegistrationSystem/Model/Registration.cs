using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistrationSystem
{
    internal class Registration
    {
        private readonly Student student;
        private readonly string semester;
        private readonly Dictionary<string, Course> courseList = new Dictionary<string, Course>();
        private readonly DateTime currentDateTime;

        public Registration(string studentID, string name, string semester, Dictionary<string, Course> courseList)
        {
            student = new Student(studentID, name);
            this.semester = semester;
            this.courseList = courseList;
            currentDateTime = DateTime.Now;


            foreach (string code in courseList.Keys)
            {
                courseList[code].Roster.Add(student.Id);
            }
        }

        public Student Student { get { return student; } }
        public string Semester { get { return semester; } }
        public Dictionary<string, Course> CourseList { get { return courseList; } }
        public DateTime CurrentDateTime { get { return currentDateTime; } }
    }
}
