using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistrationSystem
{
    internal class Student
    {
        private string id, name;
        public Student(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public string Id { get { return this.id; } set { id = value; } }
        public string Name { get { return this.name; } set { name = value; } }
    }
}
