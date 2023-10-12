using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClassesObjs
{
    class Course
    {
        private string course;

        public Course()
        {
            course = "";
        }

        public string setName(string name)
        {
            return course = name;
        }

        public override string ToString()
        {
            return course; // this method should return the name field
        }

    }
}
