namespace _22School.Models
{
    class Student : Person
    {
        public uint Id { get; set; }
        public StudentClass StudentClass { get; set; }

        public Student(string firstName,string lastName,StudentClass studentClass)
            : base(firstName,lastName)
        {
            this.StudentClass = studentClass;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} Class: {2}", this.FirstName, this.LastName, this.StudentClass.ClassId);
        }
    }
}
