using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pr._22.School
{
    class Student
    {
        string name;
        string classId;

        public Student(string name, string classId)
        {
            this.name = name;
            this.classId = classId;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ClassId
        {
            get { return classId; }
            set { classId = value; }
        }
    }
}
