using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pr._22.School
{
    class School
    {
        private static List<Student> listOfStudents = new List<Student>();
        private static Dictionary<string, Teacher> listOfTeachers = new Dictionary<string, Teacher>();

        public void AddTeacher(Teacher teacher)
        {
            listOfTeachers.Add(teacher.Name, teacher);
        }

        public void AddStudent(Student student)
        {
            listOfStudents.Add(student);
        }

        internal List<Student> ListOfStudents
        {
            get { return listOfStudents; }
            set { listOfStudents = value; }
        }

        public static Dictionary<string, Teacher> ListOfTeachers
        {
            get { return School.listOfTeachers; }
            set { School.listOfTeachers = value; }
        }
        public static List<Student> ListOfStudents1
        {
            get { return School.listOfStudents; }
            set { School.listOfStudents = value; }
        }

    }
}
