using System;
using System.Collections.Generic;
using System.Linq;

namespace _05RemoveNegativeNumbers
{
    class RemoveNegativeNumbers
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            numbers.RemoveNegativeNumbers();
 
            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}

