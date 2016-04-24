using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger factorielN = 1;
        BigInteger factorielNplus1 = 1;
        BigInteger factoriel2N = 1;
        BigInteger  catalanNumber;
        for (int i = 1; i <= n; i++)
        {
            factorielN *= i;
        }
        Console.WriteLine(factorielN);
        for (int i = 1 ; i <= 2*n; i++)
        {
            factoriel2N *= i;
        }
        for (int i = 1; i <= (n+1); i++)
        {
            factorielNplus1 *= i;
        }
        catalanNumber = factoriel2N / (factorielNplus1 * factorielN);
        Console.WriteLine("The n-th catalan number is {0}", catalanNumber);
    }
}