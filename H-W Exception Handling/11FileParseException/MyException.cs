using System;
using System.IO;

namespace _11FileParseException
{
    class MyException
    {
        static void Main()
        {
            try
            {
                ReadFile();
            }
            catch (FileParseException ex)
            {
                Console.WriteLine("An error has accured. For more information press (Y)");
                ConsoleKeyInfo keyPressed = Console.ReadKey();

                if (keyPressed.Key == ConsoleKey.Y)
                {
                    Console.WriteLine("More information -----> {0}",ex.StackTrace);
                }
            }
        }
        private static void ReadFile()
        {
            using (StreamReader readNumbers = new StreamReader(@"..\..\Numbers.txt"))
            {
                while (!readNumbers.EndOfStream)
                {
                    char num = char.Parse(readNumbers.ReadLine());
                    if (!Char.IsDigit(num))
                    {
                        throw new FileParseException("The has some lines that aren't numbers!");
                    }
                }
            }
        }
    }
}
