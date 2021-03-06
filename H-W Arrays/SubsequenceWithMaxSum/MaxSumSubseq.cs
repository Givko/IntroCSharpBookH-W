﻿using System;

class MaxSumSubseq
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int[length];
        int curMaxSum = 0;
        int MaxSum = int.MinValue;
        
        //Inserting elements in array
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        //Finding the subsequence with max sum
        for (int i = 0; i < numbers.Length; i++)
        {
            curMaxSum = 0;

            for (int j = i; j < numbers.Length; j++)
            {
                curMaxSum += numbers[j];

                //Checking if the current max subsequence is bigger the the max subsequence
                if (MaxSum < curMaxSum)
                {
                    MaxSum = curMaxSum;
                }


            }

        }
        
        Console.WriteLine(MaxSum);
    }
}

