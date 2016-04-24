using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSorting
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 3, 6, 9, 4, 0, 1, -3 };
            int min = int.MaxValue;
            int curMinPos = 0;

            //Sorting the array with selection sorting method
            for (int i = 0; i < numbers.Length; i++)
            {
                min = int.MaxValue;
                //Finding the current min element in the array
                for (int j = i; j < numbers.Length; j++)
                {
                    //Getting the current min value and it's position
                    if (min > numbers[j])
                    {
                        min = numbers[j];
                        curMinPos = j;
                    }
                }

                numbers[curMinPos] = numbers[i];
                numbers[i] = min;

                //for (int z = 0; z < numbers.Length; z++)
                //{
                //Console.Write("The {0} step looks like this: ",z);
                //    Console.Write("{0,1}", numbers[z]);
                //}
                //Console.WriteLine();
            }

            Console.Write("The sorted array looks like this: ");
            for (int k = 0; k < numbers.Length; k++)
            {
                Console.Write("{0} ", numbers[k]);
            }

            Console.WriteLine();
        }
    }
}
