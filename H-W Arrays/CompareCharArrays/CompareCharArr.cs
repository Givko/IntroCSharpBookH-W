using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArr
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the char array: ");
            int length = int.Parse(Console.ReadLine());
            char[] letters1 = new char[length];
            char[] letters2 = new char[length];
            bool theFirstIsFirst = false;
            Console.Write("Enter the first array: ");
            
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter element number {0}: ");
                letters1[i] = char.Parse(Console.ReadLine());
            }
            Console.Clear();
            
            Console.Write("Enter the second array: ");
             for (int i = 0; i < length; i++)
			{
                letters2[i] = char.Parse(Console.ReadLine());
			}

             for (int i = 0; i < length; i++)
             {
                 if (letters1[i]>letters2[i])
                 {
                     theFirstIsFirst = true;
                 }
             }

             Console.WriteLine(theFirstIsFirst ? "The first array is earlier." : "The second array is earlier.");
        }
    }
}
