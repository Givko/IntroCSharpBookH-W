using System;
using System.Collections.Generic;
using System.Linq;

namespace _03Sort
{
    class Sort
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
