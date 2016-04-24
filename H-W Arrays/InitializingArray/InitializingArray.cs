using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitializingArray
{
    class InitializingArray
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * 5;
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
