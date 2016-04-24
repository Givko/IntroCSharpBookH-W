using System;
using System.Linq;
using System.Text;

class SumOfNumbers
{
    static void Main(string[] args)
    {
        int[] sum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(sum.Sum());
    }
}

