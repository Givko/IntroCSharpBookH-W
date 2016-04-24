using System;

class DecimalToHexadecimal
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        long numberDecimal = long.Parse(Console.ReadLine());
        string numberHexa = "";
        int index = numberHexa.Length - 1;
        //Puts the decimal number into the string numberHexa in hexadecimal
        while (numberDecimal != 0)
        {
            //Checks the remainder
            if (numberDecimal % 16 == 0)
            {
                numberHexa += "0";
            }
            else if (numberDecimal % 16 == 1)
            {
                numberHexa += "1";
            }
            else if (numberDecimal % 16 == 2)
            {
                numberHexa += "2";
            }
            else if (numberDecimal % 16 == 3)
            {
                numberHexa += "3";
            }
            else if (numberDecimal % 16 == 4)
            {
                numberHexa += "4";
            }
            else if (numberDecimal % 16 == 5)
            {
                numberHexa += "5";
            }
            else if (numberDecimal % 16 == 6)
            {
                numberHexa += "6";
            }
            else if (numberDecimal % 16 == 7)
            {
                numberHexa += "7";
            }
            else if (numberDecimal % 16 == 8)
            {
                numberHexa += "8";
            }
            else if (numberDecimal % 16 == 9)
            {
                numberHexa += "9";
            }
            else if (numberDecimal % 16 == 10)
            {
                numberHexa += "A";
            }
            else if (numberDecimal % 16 == 11)
            {
                numberHexa += "B";
            }
            else if (numberDecimal % 16 == 12)
            {
                numberHexa += "C";
            }
            else if (numberDecimal % 16 == 13)
            {
                numberHexa += "D";
            }
            else if (numberDecimal % 16 == 14)
            {
                numberHexa += "E";
            }
            else if (numberDecimal % 16 == 15)
            {
                numberHexa += "F";
            }


            numberDecimal /= 16;
        }

        //Gives the integer variable "index" the value of the length of numberHexa minus 1  
        index = numberHexa.Length - 1;
        //Clearing console for the output
        for (int i = 0; i < numberHexa.Length; i++)
        {
            Console.Write("{0}", numberHexa[index - i]);
        }
        Console.WriteLine();
    }
}

