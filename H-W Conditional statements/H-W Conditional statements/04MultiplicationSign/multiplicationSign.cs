using System;

class MultiplicationSign
{
    static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());

        double secondNum = double.Parse(Console.ReadLine());

        double thirdNum = double.Parse(Console.ReadLine());

        if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
        {
            Console.WriteLine("0");
        }
        else if ((firstNum > 0 && secondNum > 0 && thirdNum > 0) || (firstNum > 0 && secondNum < 0 && thirdNum < 0) || (firstNum < 0 && secondNum < 0 && thirdNum > 0) || (firstNum < 0 && secondNum > 0 && thirdNum < 0))
        {
            Console.WriteLine("+");
        }
        else if ((firstNum < 0 && secondNum < 0 && thirdNum < 0) || (firstNum > 0 && secondNum > 0 && thirdNum < 0) || (firstNum > 0 && secondNum < 0 && thirdNum > 0) || (firstNum < 0 && secondNum > 0 && thirdNum > 0))
        {
            Console.WriteLine("-");
        }
    }
}

