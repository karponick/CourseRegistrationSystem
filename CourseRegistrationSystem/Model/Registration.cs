using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistrationSystem
{
    public class Registration
    {
        private readonly Student student;
        private readonly string semester;
        private readonly Course course;
        private readonly DateTime currentDateTime;

        public Registration(string studentID, string studentName, string semester, Course course)
        {
            student = new Student(studentID, studentName);
            this.semester = semester;
            this.course = course;
            currentDateTime = DateTime.Now;
        }

        public Student Student { get { return student; } }
        public string Semester { get { return semester; } }
        public DateTime CurrentDateTime { get { return currentDateTime; } }
        public string[] ToArray()
        {
            Random rand = new Random();
            string registration_id = student.Id + course.Code + rand.Next(10000).ToString();
            return new string[] { registration_id, student.Id, course.Code, DateTime.Now.ToString(), semester};
        }
    }
}
