using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSequenceOfKElements
{
    class SequnceOfKElements
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the lengthof the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            Console.Write("Enter sequence length: ");
            int k = int.Parse(Console.ReadLine());
            int curSequence = 0;
            int maxSequence = int.MinValue;
            int bestindex = 0;

            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter the {0} element in the array: ",i+1);
                numbers[i] = int.Parse(Console.ReadLine());
                
            }


            for (int i = 0; i <= numbers.Length-k; i++)
            {
                curSequence = 0;
                for (int j = 0; j < k; j++)
                {
                    curSequence += numbers[i + j];
                }
                if (curSequence>maxSequence)
                {
                    maxSequence = curSequence;
                    bestindex = i;
                }
            }
            Console.Clear();

            Console.Write("The sequence of {0} elements which has the maximal sum of {1} are:  ",k,maxSequence);
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0}, ",numbers[bestindex]);
                bestindex++;
            }
            Console.WriteLine();
        }
    }
}
