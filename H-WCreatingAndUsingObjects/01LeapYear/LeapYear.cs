using System;

class Program
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        IsLeapYear(year);
    }
    private static void IsLeapYear(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine("Leap");
                }
                else
                {
                    Console.WriteLine("Common");
                }
            }
            else
            {
                Console.WriteLine("Leap");
            }
        }
        else
        {
            Console.WriteLine("Common");
        }
    }
}

