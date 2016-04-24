using System;

class BinarySearch
{
    static void Main(string[] args)
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21,22, 23, 24, 25, 26, 27, 28, 29, 30 };
        int element = int.Parse(Console.ReadLine());
        int maxIndex = numbers.Length;
        int minIndex = 0;
        int curMid;
       
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            curMid = (minIndex + maxIndex)/2;
            if (numbers[curMid] == element)
            {
                Console.WriteLine("{0} is found on position {1}",element,curMid);
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

    }
}

