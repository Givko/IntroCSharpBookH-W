using System;
using System.Collections.Generic;
using System.Linq;

class SumAvg
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        Console.WriteLine(numbers.Sum());
        Console.WriteLine(numbers.Average());
    }
}
/*
    string number = Console.ReadLine();
    while(!String.IsNullOrEmpty(number))
    {
        numbers.Add(int.Parse(number));
    }
*/