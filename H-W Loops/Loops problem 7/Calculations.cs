using System;
using System.Numerics;

class Calculations
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger factorielN = 1;
        int factorielK = 1;
        int counter = 1;
        BigInteger factorielNMinusK = 1;
        int combinations;

        while (counter <= Math.Max(n, k))
        {
            if (counter <= n)
            {
                factorielN *= counter;
                
            }
            if (counter <= k)
            {
                factorielK *= counter;
            }
            counter++;
        }
        for (long i = 1; i <=(n-k); i++)
        {
            factorielNMinusK *= i;
        }
        BigInteger product = factorielK * factorielNMinusK;
        combinations = (int)(factorielN / (factorielK * factorielNMinusK));
        Console.WriteLine("the combinations are {0}", combinations);
    }
}

