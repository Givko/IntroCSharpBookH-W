using System;

class GCD
{
    static void Main(string[] args)
    {
        Console.Write("a= ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b= ");
        int b = int.Parse(Console.ReadLine());

        a = Math.Abs(a);
        b = Math.Abs(b);

        while (a != b)
        {
            if (a > b)
            {
                a -= b;
            }
            else
            {
                b -= a;
            }
        }

        Console.WriteLine("GCD = {0}", a);
    }
}

