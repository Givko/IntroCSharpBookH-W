using System;

namespace _22School.Models
{
    class Discipline
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null");
                }

                this.name = value;
            }
        }

        public uint NumberOfLessons { get; set; }

        public uint NumberOfExercises { get; set; }

        public Discipline(string name, uint numberOfLessons)
            : this(name, numberOfLessons, 0)
        {

        }

        public Discipline(string name, uint numberOfLessons, uint numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLessons = numberOfLessons;
            this.NumberOfExercises = numberOfExercises;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}/n/rLessons: {1}/n/rExercises: {2}", this.Name, this.NumberOfLessons, this.NumberOfExercises);
        }
    }
}
