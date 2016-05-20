using System;
using System.Collections.Generic;
using System.Linq;

class BiggerNumber
{
    static void Main(string[] args)
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMax(num1,num2));
    }

    private static int GetMax(int number1, int number2)
    {
        if (number1>number2)
        {
            return number1;
        }
        else
        {
            return number2;
        }
    }
}


