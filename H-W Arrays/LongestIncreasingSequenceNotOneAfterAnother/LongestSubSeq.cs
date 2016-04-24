using System;

class LongestSubSeq
{
    static void Main(string[] args)
    {
        int[] numbers = { 9, 6, 2, 7, 4, 7, 6, 5, 8 };
        int[] sequenceLength = new int[numbers.Length];
        int[] prevInd = new int[numbers.Length];
        int maxBefore = 0;
        int lastIndex = 0;
        int maxCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            maxBefore = 0;
            for (int j = 0; j < i; j++)
            {
                if (numbers[i] > numbers[j] && sequenceLength[j] > maxBefore)
                {
                    maxBefore = sequenceLength[j];
                    prevInd[i] = j;
                }
            }
            sequenceLength[i] = maxBefore + 1;
            if (sequenceLength[i] > maxCount)
            {
                maxCount++;
                lastIndex = i;
            }
        }        
        int[] bestSequence = new int[maxCount];        
        for (int i = 0; i < maxCount; i++)
        {
            bestSequence[i] = numbers[lastIndex];
            lastIndex = prevInd[lastIndex];
        }
    
        for (int i = 0; i < maxCount; i++)
        {
            Console.Write(bestSequence[maxCount-i-1]);
        }    
    }
}
