using System;

class NumbersAsWords
{
    static void Main()
    {
        Console.Write("Enter number from 0 to 999: ");
        int number = int.Parse(Console.ReadLine());
        string numberInWords = "";
        string[] digits = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] teens = { "eleven", "twelve", "thirteen", "forteen", "fifteen", "sixteen", "seventeen", "eightteen", "nineteen" };
        string[] tenths = new string[] { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninty" };
        //Finding if the numbers is in the given range
        if (number <= 999 && number >= 0)
        {
            //Checking of the number is zero
            if (number== 0)
            {
                numberInWords = "zero";
            }
            //Checking if the number has hundreds and with the help of an array concatenating the hundrends to the string
            if (number >= 100 && number <= 999)
            {
                numberInWords += digits[(number / 100) - 1] + " hundred ";
            }
            //Checking to see if the tenths are between 11 and 19 and with the halp of an array concatenating the teens to the string
            if (number % 100 >= 11 && number % 100 <= 19)
            {
                //Checking if the string was empty or not
                if (numberInWords!="")
                {
                    numberInWords += "and " + teens[(number % 100) - 11];
                }
                else
                {
                    numberInWords += teens[(number % 100) - 11];
                }
                
            }
            //Cheking the tenths ind the ones in the numbers and with the help of two arrays concatenating them to the string
            else if ((number % 100) / 10 >= 1 && (number % 100) / 10 <= 9)
            {
                //Checking if the string was empty or not
                if (numberInWords != "")
                {
                    numberInWords += "and " + tenths[(number % 100) / 10-1];
                }
                else
                {
                    numberInWords += tenths[(number % 100) / 10 - 1];
                }
            }
            if ((number % 100) % 10 >= 1 && (number % 100) % 10 <= 9)
            {
                numberInWords += " " + digits[((number % 100) % 10) - 1];
            }

            Console.WriteLine(numberInWords);
        }
        else
        {
            Console.WriteLine("Number is not in range.");
        }
    }
}
