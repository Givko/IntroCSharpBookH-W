using System;

class SortThreeNumbers
{
    static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());

        if (firstNum >= secondNum)
        {
            if (secondNum >= thirdNum)
            {
                Console.WriteLine(firstNum + " " + secondNum + " " + thirdNum);
            }
            else if (firstNum >= thirdNum)
            {
                Console.WriteLine(firstNum + " " + thirdNum + " " + secondNum);
            }
            else
            {
                Console.WriteLine(thirdNum + " " + firstNum + " " + secondNum);
            }
        }
        else
        {
            if (firstNum >= thirdNum)
            {
                Console.WriteLine(secondNum + " " + firstNum + " " + thirdNum);
            }
            else if (secondNum >= thirdNum)
            {
                Console.WriteLine(secondNum + " " + thirdNum + " " + firstNum);
            }
            else
            {
                Console.WriteLine(thirdNum + " " + secondNum + " " + firstNum);
            }
        }
    }
}

