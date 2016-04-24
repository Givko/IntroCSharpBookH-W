using System;
using System.Collections.Generic;

namespace _22School.Models
{
    class Teacher : Person
    {
        private HashSet<Discipline> disciplines;

        public HashSet<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The discipline cannot be null.");
                }

                this.disciplines = value;
            }
        }

        public Teacher(string firstName, string lastName, Discipline discipline)
            : base(firstName, lastName)
        {
            this.Disciplines = new HashSet<Discipline>();
            this.Disciplines.Add(discipline);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} Disciplines: {2}",this.FirstName,this.LastName,string.Join(", ",this.Disciplines));
        }
    }
}
