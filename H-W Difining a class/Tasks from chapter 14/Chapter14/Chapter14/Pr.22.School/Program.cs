using System;
using System.Collections.Generic;
using System.Text;

namespace Pr._22.School
{
    class Program
    {
        static StringBuilder result = new StringBuilder();

        static void Main(string[] args)
        {
            ReadInput();
            Console.WriteLine(result.ToString());
        }

        public static void ReadInput()
        {
            string line;
            line = Console.ReadLine();

            while (line != "End.")
            {
                string[] separators = { ",", "(", ")" };
                string[] expectedComand = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < expectedComand.Length; i++)
                {
                    expectedComand[i] = expectedComand[i].Trim();
                }
                ComandExecutes(expectedComand);
                line = Console.ReadLine();

            }
        }

        private static void ComandExecutes(string[] expectedComand)
        {

            switch (expectedComand[0])
            {
                case "AddStudent":
                    {
                        School.ListOfStudents1.Add(new Student(expectedComand[1], expectedComand[2]));
                        result.Append("Student added." + System.Environment.NewLine);
                        return;
                    }
                case "AddTeacher":
                    {
                        School.ListOfTeachers.Add(expectedComand[1], new Teacher(expectedComand[1]));
                        result.Append("Teacher added." + System.Environment.NewLine);
                        return;
                    }
                case "AddDiscipline":
                    {
                        if (School.ListOfTeachers.ContainsKey(expectedComand[1]))
                        {
                            School.ListOfTeachers[expectedComand[1]].AddDiscipline(expectedComand[2],
                           int.Parse(expectedComand[3]), int.Parse(expectedComand[4]));
                        }
                        else
                        {
                            School.ListOfTeachers.Add(expectedComand[1], new Teacher(expectedComand[1]));
                            School.ListOfTeachers[expectedComand[1]].AddDiscipline(expectedComand[2],
                                int.Parse(expectedComand[3]), int.Parse(expectedComand[4]));
                        }
                        result.Append("Discipline added." + System.Environment.NewLine);
                        return;
                    }
                case "PrintStudents":
                    {
                        bool isStudentInThisClass = false;
                        foreach (var item in School.ListOfStudents1)
                        {
                            if (item.ClassId.Equals(expectedComand[1]))
                            {
                                isStudentInThisClass = true;
                                result.Append(item.Name + System.Environment.NewLine);
                            }
                        }
                        if (!isStudentInThisClass)
                        {
                            result.Append("No students." + System.Environment.NewLine);
                        }
                        return;
                    }
                case "PrintTeacher":
                    {
                        bool isFoundTeacher = false;
                        foreach (var teacher in School.ListOfTeachers)
                        {
                            for (int i = 0; i < teacher.Value.ListOfDiscipline.Count; i++)
                            {
                                if (teacher.Value.ListOfDiscipline[i].Name.Equals(expectedComand[1]))
                                {
                                    isFoundTeacher = true;
                                    result.Append(teacher.Value + System.Environment.NewLine);
                                }
                            }
                        }
                        if (!isFoundTeacher)
                        {
                            result.Append("No teacher.");
                        }
                        break;
                    }
                default:
                    {
                        result.Append("Invalid comand");
                        return;
                    }
            }
        }
    }
}

