using System;

class HexadecimalToDecimal
{
    static void Main(string[] args)
    {
        Console.Write("Enter hexadecimal number: ");
        string numberHexa = Console.ReadLine();
        double numberDecimal = 0;
        int index = numberHexa.Length - 1;

        for (int i = 0; i < numberHexa.Length; i++)
        {
            if (numberHexa[index - i] == '0')
            {
                numberDecimal += 0 * Math.Pow(16, i);
            }
            else if (numberHexa[index - i] == '1')
            {
                numberDecimal += 1 * Math.Pow(16, i);
            }
            else if (numberHexa[index - i] == '2')
            {
                numberDecimal += 2 * Math.Pow(16, i);
            }
            else if (numberHexa[index - i] == '3')
            {
                numberDecimal += 3 * Math.Pow(16, i);
            }
            else if (numberHexa[index - i] == '4')
            {
                numberDecimal += 4 * Math.Pow(16, i);
            }
            else if (numberHexa[index - i] == '5')
            {
                numberDecimal += 5 * Math.Pow(16, i);
            }
            else if (numberHexa[index - i] == '6')
            {
                numberDecimal += 6 * Math.Pow(16, i);
            }
            else if (numberHexa[index - i] == '7')
            {
                numberDecimal += 7 * Math.Pow(16, i);
            }
            else if (numberHexa[index - i] == '8')
            {
                numberDecimal += 8 * Math.Pow(16, i);
            }
            else if (numberHexa[index - i] == '9')
            {
                numberDecimal += 9 * Math.Pow(16, i);
            }
            else if (numberHexa[index - i] == 'A')
            {
                numberDecimal += 10 * Math.Pow(16, i);
            }
            else if (numberHexa[index - i] == 'B')
            {
                numberDecimal += 11 * Math.Pow(16, i);
            }
            else if (numberHexa[index - i] == 'C')
            {
                numberDecimal += 12 * Math.Pow(16, i);
            }
            else if (numberHexa[index - i] == 'D')
            {
                numberDecimal += 13 * Math.Pow(16, i);
            }
            else if (numberHexa[index - i] == 'E')
            {
                numberDecimal += 14 * Math.Pow(16, i);
            }
            else if (numberHexa[index - i] == 'F')
            {
                numberDecimal += 15 * Math.Pow(16, i);
            }
        }
        Console.WriteLine("{0:#.##}", numberDecimal);
    }
}

