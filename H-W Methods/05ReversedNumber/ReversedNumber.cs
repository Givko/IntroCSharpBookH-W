using System;
using System.Collections.Generic;
using System.Linq;

class ReversedNumber
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        double reversedNumber = GetReversed(number);
        Console.WriteLine(reversedNumber);
    }

    private static double GetReversed(string number)
    {
        double numReversed;
        string backwards="";
        
        for (int i = 0; i < number.Length; i++)
        {
            backwards += number[number.Length-1-i];
        }
        
        numReversed = double.Parse(backwards);
        return numReversed;
    }
}

