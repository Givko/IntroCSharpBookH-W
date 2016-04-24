using System;

class BiggestOfFive
{
    static void Main()
    {
        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());
        double forthNum = double.Parse(Console.ReadLine());
        double fifthNum = double.Parse(Console.ReadLine());

        if (firstNum >= secondNum && firstNum >= thirdNum && firstNum >= forthNum && firstNum >= fifthNum)
        {
            Console.WriteLine(firstNum);
        }
        else if (firstNum <= secondNum && secondNum >= thirdNum && secondNum >= forthNum && secondNum >= fifthNum)
        {
            Console.WriteLine(secondNum);
        }
        else if (firstNum <= thirdNum && secondNum <= thirdNum && thirdNum >= forthNum && thirdNum >= fifthNum)
        {
            Console.WriteLine(thirdNum);
        }
        else if (firstNum <= forthNum && secondNum <= forthNum && thirdNum <= forthNum && forthNum >= fifthNum)
        {
            Console.WriteLine(forthNum);
        }
        else
        {
            Console.WriteLine(fifthNum);
        }
    }
}

