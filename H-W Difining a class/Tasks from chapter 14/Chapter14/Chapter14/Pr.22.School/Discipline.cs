using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pr._22.School
{
    class Discipline
    {
        string name;
        int numberOfLessons;
        int numberOfEx;

        public Discipline(string name, int numberOfLessons, int numberOfEx)
        {
            this.name = name;
            this.numberOfLessons = numberOfLessons;
            this.numberOfEx = numberOfEx;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(name + ", ");
            sb.Append(numberOfLessons + ", ");
            sb.Append(numberOfEx + ", ");
            return sb.ToString();
        }

        public string Name
        {
            get { return name; }
        }
    }
}
