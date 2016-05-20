using System;

class LongestSubSeq
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int[] sequenceLength = new int[numbers.Length];
        int[] prevInd = new int[numbers.Length];
        int maxBefore = 0;
        int lastIndex = 0;
        int maxCount = 0;

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            maxBefore = 0;
            for (int j = 0; j < i; j++)
            {
                if (numbers[i] >= numbers[j] && sequenceLength[j] > maxBefore)
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
        //int n = int.Parse(Console.ReadLine());
        //int k = int.Parse(Console.ReadLine());
        //int[] numbers = new int[n];
        //int sum = 0;

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}

        //Array.Sort(numbers);

        //for (int i = numbers.Length-1; i > numbers.Length-1-k; i--)
        //{
        //    sum += numbers[i];
        //}

        //Console.WriteLine(sum);
