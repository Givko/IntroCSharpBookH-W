using System;
using System.Collections.Generic;
using System.Linq;

class Reverse
{
    static void Main()
    {
        Stack<int> numbers = new Stack<int>();
        string number = Console.ReadLine();

        while (!String.IsNullOrEmpty(number))
        {
            numbers.Push(int.Parse(number));
            number = Console.ReadLine();
        }

        while (true)
        {
            if (numbers.Count == 0)
            {
                break;
            }
            number = numbers.Pop().ToString();
            Console.WriteLine(number);
        }
    }
}