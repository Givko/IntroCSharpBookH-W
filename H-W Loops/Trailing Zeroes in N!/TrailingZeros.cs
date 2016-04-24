using System;
using System.Numerics;

class TrailingZeros
{
    static void Main(string[] args)
    {
        Console.Write("Enter n:");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorielN = 1;
        int counter = 0;

        //Calculates n!
        for (int i = 1; i <= n; i++)
        {
            factorielN *= i;
        }

        // Finds out how many trailing zeros are there
        while (factorielN % 10 == 0)
        {
            factorielN /= 10;
            counter++;
        }

        Console.WriteLine(counter);
    }
}

