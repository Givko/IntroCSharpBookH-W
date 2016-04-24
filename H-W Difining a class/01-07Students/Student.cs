using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_07Students
{
    class Student
    {
        private string studentName;
        private string course;
        private string specialty;
        private string university;
        private string email;
        private string phoneNumber;
        static private int numberOfStudents;
        public Student(string studentName, string course)
            : this(studentName, course, null)
        {

        }
        public Student(string studentName, string course, string university): this(studentName,course,university,null,null)
        {

        }
        public Student(string studentName,string course,string university,string email,string phoneNumber)
        {
            this.StudentName = studentName;
            this.Course = course;
            this.Univeristy = university;
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            numberOfStudents++;
        }

        public string StudentName
        {
            get
            {
                return this.studentName;
            }
            set
            {
                this.studentName = value;
            }
        }

        public string Course
        {
            get
            {
                return this.course;
            }
            set
            {
                this.course = value;
            }
        }
        public string Specialty
        {
            get
            {
                return this.specialty;
            }
            set
            {
                this.specialty = value;
            }
        }
        public string Univeristy
        {
            get
            {
                return this.university;
            }
            set
            {
                this.university = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }

        public string PrintStudentInfo()
        {
            StringBuilder studentInfo = new StringBuilder(string.Format("{0} {1}Course: {2}{3}", this.studentName,Environment.NewLine, this.course,Environment.NewLine));
            
            if (!String.IsNullOrEmpty(this.specialty))
            {
                studentInfo.Append(string.Format("Specialty: {0}{1}",this.specialty,Environment.NewLine));
            }
            if (!String.IsNullOrEmpty(this.university))
            {
                studentInfo.Append(string.Format("Univeristy: {0}{1}", this.university, Environment.NewLine));
            }
            if (!String.IsNullOrEmpty(this.email))
            {
                studentInfo.Append(string.Format("Email: {0}{1}",this.email,Environment.NewLine));
            }
            if (!String.IsNullOrEmpty(this.PhoneNumber))
            {
                studentInfo.Append(string.Format("Phone number: {0}{1}",this.phoneNumber,Environment.NewLine));
            }
            
            return studentInfo.ToString();
        }
    }
}
