using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class CopyBinaryFileAndCompare
{
    private static void CopyFile(string path, string copy)
    {
        //byte[] bytes = File.ReadAllBytes(path);
        //File.WriteAllBytes(copy, bytes);
        try
        {
            File.Copy(path, copy);
        }
        catch (IOException ex)
        {
            Console.WriteLine("A problem has accured during the copying of the file. If you want to know more click (Y).");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Y)
            {
                Console.WriteLine("More info about the problem--------> {0}",ex.StackTrace);
            }
        }
    }
    private static void CompareFiles(string file1, string file2)
    {
        bool areSame = File.Equals(file1, file2);
        if (areSame)
        {
            Console.WriteLine("This is the same file");
        }
        else
        {
            Console.WriteLine("This is not the original file it is a copy or something else.");
            Console.WriteLine("File path {0}", file2);
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter file path: ");
        string filePath = Console.ReadLine();

        Console.WriteLine("What will be the name of the copied file: ");
        string name = Console.ReadLine();
        string copy = string.Format(@"..\..\{0}{1}", name, filePath.Substring(filePath.LastIndexOf('.'), filePath.Length - filePath.LastIndexOf('.')));

        CopyFile(filePath, copy);
        CompareFiles(filePath, copy);
    }
}