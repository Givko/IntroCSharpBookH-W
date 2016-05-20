using System;

class BinarySearch
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int[length];
        int maxIndex = numbers.Length;
        int minIndex = 0;
        int curMid;
        bool hasElement = true;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int element = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Length / 2; i++)
        {
            curMid = (minIndex + maxIndex)/2;
            if (numbers[curMid] == element)
            {
                hasElement = false;
                Console.WriteLine(curMid);
                break;
            }
            else if (numbers[curMid]>element)
            {
                maxIndex = curMid - 1;
            }
            else
            {
                minIndex = curMid + 1;
            }
        }
        if (hasElement)
        {
            Console.WriteLine(-1);
        }
    }
}

