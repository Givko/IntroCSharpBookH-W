using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_07Students
{
    static class StudentTest
    {
        private static List<Student> Students { get; set; }
        public static void GenerateStudent()
        {
            Students = new List<Student>();

            string[] names = new string[] 
            { 
                "Maria Kostadinova Gogova",
                "Zhivko Milkov Milev",
                "Ivailo Ivanov Petrov",
                "Natalia Georgieva Georgieva" 
            };
            string[] specialty = new string[] { "STD", "Finance", "Geography", "", "Accounting", "Computer science" };
            string[] university = new string[] { "", "University of Plovdiv", "SoftUni", "Oxord", "MIT", "Harvard" };
            string[] email = new string[] { "", "greedy__@abv.bg", "milevjivko@gmail.com", "yavor98@yahoo.com", "Daniel67@gmail.com" };
            string[] phoneNumbers = new string[] { "", "0884704822", "0898479351", "0898654585", "0885362154" };
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                Students.Add(new Student(names[rand.Next(names.Length)], rand.Next(1, 5).ToString(), university[rand.Next(university.Length)], email[rand.Next(email.Length)], phoneNumbers[rand.Next(phoneNumbers.Length)]));
            }
        }

        public static void ShowStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student.PrintStudentInfo());
            }
        }
    }
}
