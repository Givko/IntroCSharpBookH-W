using System;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        long numberDecimal = int.Parse(Console.ReadLine());
        string numberBinary = "";
        int index = numberBinary.Length - 1;

        //Converts from decimal to binary
        while (numberDecimal != 0)
        {
            numberBinary += Convert.ToString(numberDecimal % 2);
            numberDecimal /= 2;
        }

        index = numberBinary.Length - 1;

        Console.Clear();
        //Clearing console for the output
        for (int i = 0; i < numberBinary.Length; i++)
        {
            Console.Write("{0, -2}", numberBinary[index - i]);
        }
        Console.WriteLine();

    }
}

