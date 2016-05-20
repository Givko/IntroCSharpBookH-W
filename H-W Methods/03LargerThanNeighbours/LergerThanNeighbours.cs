using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }
    }

    private static bool IsLargerThanNeighbours(int[] numbers, int index)
    {
        bool isLarger = false;
        if ((index - 1) >= 0 && (index + 1) < numbers.Length)
        {
            if (numbers[index] > numbers[index + 1] && numbers[index] > numbers[index - 1])
            {
                isLarger = true;
                
            }    
        }
        else if ((index - 1) >= 0 && (index + 1) >= numbers.Length)
        {
            if (numbers[index] > numbers[index - 1])
            {
                isLarger = true;
                
            }
        }
        else if (((index - 1) < 0) && ((index + 1) < numbers.Length))
        {
            if (numbers[index] > numbers[index + 1])
            {
                isLarger = true;
            }
        }
        return isLarger;
    }
}

