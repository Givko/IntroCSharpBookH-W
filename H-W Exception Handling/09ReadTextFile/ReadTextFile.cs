using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

class ReadTextFile
{

    private static void ReadFile(string path, StringBuilder textFromFile)
    {
        using (StreamReader fileReader = new StreamReader(path, Encoding.UTF8))
        {
            while (!fileReader.EndOfStream)
            {
                textFromFile.Append(fileReader.ReadLine());
            }
        }
    }
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        StringBuilder textFromFile = new StringBuilder();

        Console.WriteLine("Enter path to file:");
        string path = Console.ReadLine();

        try
        {
            ReadFile(path, textFromFile);
            Console.WriteLine(textFromFile);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("File was not found. For more information click ( y )");
            string answer = Console.ReadLine();

            if (answer == "y" || answer == "Y")
            {
                Console.WriteLine("Information about the exception-----> {0}", ex.StackTrace);
            }
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine("The path entered was too long. For more information click ( y )");
            string answer = Console.ReadLine();

            if (answer == "y" || answer == "Y")
            {
                Console.WriteLine("Information about the exception-----> {0}", ex.StackTrace);
            }
        }
        catch(DirectoryNotFoundException ex)
        {
            Console.WriteLine("The directory entered was not found. For more information click ( y )");
            string answer = Console.ReadLine();

            if (answer == "y" || answer == "Y")
            {
                Console.WriteLine("Information about the exception-----> {0}", ex.StackTrace);
            }
        }
    }
}