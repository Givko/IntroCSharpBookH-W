using System;
using System.Collections.Generic;
using System.Linq;

class SumOfIntegerArrays
{
    static void Main()
    {
        string str = Console.ReadLine;
        int[] number1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] number2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        string sum = AddArrays(number1, number2);

        for (int i = sum.Length; i >= 0; i--)
        {
            Console.Write("{0} ",sum[i]);
        }
    }

    private static string AddArrays(int[] number1, int[] number2)
    {
        string num1 = "";
        string num2 = "";
        string sum;
        
        for (int i = number1.Length - 1; i >= 0; i--)
        {
            num1 += number1[i].ToString();
        }
        
        for (int i = number2.Length - 1; i >= 0; i--)
        {
            num2 += number2[i].ToString();
        }
       
        sum = (int.Parse(num1) + int.Parse(num2)).ToString();
        
        return sum;
    }
}

