using System;
using System.Collections.Generic;
using System.Linq;

class LastDigit
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigit(number));
    }

    private static string GetLastDigit(int number)
    {
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        return digits[number%10];
    }
}

