using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistrationSystem
{
    public class Student
    {
        private string id, name;
        public Student(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public string Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
    }
}
