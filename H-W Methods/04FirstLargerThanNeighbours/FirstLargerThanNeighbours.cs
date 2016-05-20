using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int[] sequenceOne = { 1,5,7,8,9,10,5};
            int[] sequenceTwo = { 1,2,3,4,5,6,6};
            int[] sequenceThree = { 1, 1, 1 };
            
            Console.WriteLine(GetFirstLargerThanNeighbours(sequenceOne));
            Console.WriteLine(GetFirstLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(GetFirstLargerThanNeighbours(sequenceThree));
        }
        private static int GetFirstLargerThanNeighbours(int[] sequence)
        {
            for (int i = 0; i < sequence.Length; i++)
            {
                if ((i - 1) >= 0 && (i + 1) < sequence.Length)
                {
                    if (sequence[i] > sequence[i + 1] && sequence[i] > sequence[i - 1])
                    {
                        return sequence[i];

                    }
                }
                else if ((i - 1) >= 0 && (i + 1) >= sequence.Length)
                {
                    if (sequence[i] > sequence[i - 1])
                    {
                        return sequence[i];

                    }
                }
                else if (((i - 1) < 0) && ((i + 1) < sequence.Length))
                {
                    if (sequence[i] > sequence[i + 1])
                    {
                        return sequence[i];
                    }
                }
            }

            return -1;
        }
    }
}
