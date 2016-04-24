using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pr._22.School
{
    class Teacher
    {
        string name;
        List<Discipline> listOfDiscipline = new List<Discipline>();

        public void AddDiscipline(string name, int numberOfLessons, int numberOfEx)
        {
            this.listOfDiscipline.Add(new Discipline(name, numberOfLessons, numberOfEx));
        }

        public Teacher(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Teacher name:" + name);
            foreach (var item in listOfDiscipline)
            {
                sb.Append(", " + item.ToString());
            }
            return sb.ToString();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        internal List<Discipline> ListOfDiscipline
        {
            get { return listOfDiscipline; }
            set { listOfDiscipline = value; }
        }
    }
}
