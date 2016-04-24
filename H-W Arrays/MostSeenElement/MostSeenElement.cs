using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostSeenElement
{
    class MostSeenElement
    {
        static void Main()
        {
            Console.Write("Enter length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            int timesSeenCurElement = 0;
            int timesSeenMostSeenElement = 0;
            int counter = 0;
            int indexOfMostSeenElement = 0;

            //Input elements in array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter the {0} element in the array.", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //Finding the most seen element in the array 
            for (int i = 0; i < numbers.Length; i++)
            {
                counter = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                    }
                    timesSeenCurElement = counter;
                }

                //Checking if the currentSequence is longer than the bestSequence.
                //And getting the start position of the sequence(bestIndex)
                if (timesSeenMostSeenElement < timesSeenCurElement)
                {
                    timesSeenMostSeenElement = timesSeenCurElement;
                    indexOfMostSeenElement = i;
                }
            }

            //Printing the bestSequence
            Console.Write("The longest sequence in the array is:{ ");
            while (timesSeenMostSeenElement > 0)
            {
                Console.Write(" {0}, ", numbers[indexOfMostSeenElement]);
                timesSeenMostSeenElement--;
            }
            Console.WriteLine("}");
        }
    }
}
