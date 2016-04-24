using System.Collections.Generic;

namespace _22School.Models
{
    class StudentClass
    {
        public HashSet<Student> Students { get; set; }

        public HashSet<Teacher> Teachers { get; set; }

        public string ClassId { get; set; }

        public StudentClass(string classId)
        {
            this.Students = new HashSet<Student>();
            this.Teachers = new HashSet<Teacher>();
            this.ClassId = classId;
        }

        public override string ToString()
        {
            return string.Format("Class: {0} /n/rTeacher: {1}/n/rStudents: {2}",this.ClassId,string.Join(", ",this.Students),string.Join(", ",this.Teachers));
        }
    }
}
