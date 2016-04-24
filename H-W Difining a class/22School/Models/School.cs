using System;
using System.Collections.Generic;
using System.Text;

namespace _22School.Models
{
    static class School
    {
        public static HashSet<StudentClass> StudentClasses { get; set; }

        public static HashSet<Student> Students { get; set; }

        public static HashSet<Teacher> Teachers { get; set; }

        static School()
        {
            StudentClasses = new HashSet<StudentClass>();
            Students = new HashSet<Student>();
            Teachers = new HashSet<Teacher>();
        }
    }
}
