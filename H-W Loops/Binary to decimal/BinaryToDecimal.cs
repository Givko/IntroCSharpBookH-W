using System;

class BinaryToDecimal
{
    static void Main(string[] args)
    {
        Console.Write("Enter binary number: ");
        string numberBinary = Console.ReadLine();
        long numberDecimal = 0;
        int index = numberBinary.Length - 1;

        for (int i = 0; i < numberBinary.Length; i++)
        {
            if (numberBinary[index - i] == '1')
            {
                numberDecimal += (long)Math.Pow(2, i);
            }
        }

        Console.Clear();
        Console.WriteLine("The number {0}(binary) is the number {1}(decimal).", numberBinary, numberDecimal);
    }
}

