using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter number: ");
        double num2 = double.Parse(Console.ReadLine());
        double swap;

        if (num1>num2)
        {
            swap = num1;
            num1 = num2;
            num2 = swap;
        }

        Console.WriteLine("{0} {1} ",num1,num2);
    }
}

