using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _12ReadFileFromPath
{
    class ReadFileFromPath
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string text;
            
            try
            {
               text = File.ReadAllText(path);
               Console.WriteLine(text);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("{0}",ex.Message);
            }            
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("{0}",ex.Message);
            }
            catch(PathTooLongException ex)
            {
                Console.WriteLine("{0}",ex.Message);
            }
            catch(IOException ex)
            {
                Console.WriteLine("{0}",ex.Message);
            }
        }
    }
}
