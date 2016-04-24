using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the two arrays: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            int[] numbers2 = new int[length];
            bool isSame = true;

            Console.WriteLine("Now fill the arrays: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write("Add the {0} element in the first array: ",i+1);
                numbers[i] = int.Parse(Console.ReadLine());
                Console.Write("Add the {0} element in the second array: ",i+1);
                numbers2[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            for (int index = 0; index < length; index++)
            {
                if (numbers[index]!=numbers2[index])
                {
                    isSame = false;
                }
            }
            
            Console.WriteLine(isSame);
        }
    }
}
