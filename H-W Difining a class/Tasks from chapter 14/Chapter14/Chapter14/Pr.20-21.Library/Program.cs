using System;
using System.Collections.Generic;
using System.Text;

namespace Pr._20_21.Library
{
    class Program
    {
        static StringBuilder outputString = new StringBuilder();

        static void StartTesting()
        {
            Library helikon = new Library("Helikon");
            string row = Console.ReadLine();
            while (row != String.Empty)
            {
                string[] separators = { ",", "(", ")" };
                string[] inputLine = row.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < inputLine.Length; i++)
                {
                    inputLine[i] = inputLine[i].Trim();
                }
                ComandExecutes(inputLine, helikon);
                row = Console.ReadLine();
            }
        }

        static void ComandExecutes(string[] inputLine, Library helikon)
        {
            switch (inputLine[0])
            {
                case "AddBook":
                    {
                        outputString.Append(helikon.AddBook
                            (new Book(inputLine[1], inputLine[2], inputLine[3], int.Parse(inputLine[4]), inputLine[5])) + System.Environment.NewLine);
                        break;
                    }
                case "SearchAuthor":
                    {
                        outputString.Append(helikon.SearchAuthor(inputLine[1]));
                        break;
                    }
                case "SearchTitle":
                    {
                        outputString.Append(helikon.SearchTitle(inputLine[1]) + System.Environment.NewLine);
                        break;
                    }
                case "DeleteBook":
                    {
                        outputString.Append(helikon.DeleteBook(
                            helikon.Books.Find(x => x.Title.Equals(inputLine[1]))) + System.Environment.NewLine);
                        break;
                    }
                case "DeleteAllBooks":
                    {
                        outputString.Append(helikon.DeleteAllBooks(inputLine[1]) + System.Environment.NewLine);
                        break;
                    }
                default:
                    {
                        outputString.Append("Unknown operation." + System.Environment.NewLine);
                        break;
                    }
            }
        }

        static void PrintOutput()
        {
            Console.WriteLine(outputString.ToString());
        }

        static void Main(string[] args)
        {
            StartTesting();
            PrintOutput();
        }

    }
}




