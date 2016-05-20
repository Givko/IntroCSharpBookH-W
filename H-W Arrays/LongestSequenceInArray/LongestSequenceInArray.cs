using System;

class Program
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int[length];
        int currentSequence = 0;
        int bestSequence = 0;
        int counter = 0;
        int bestIndex = 0;

        //Input elements in array
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        //Finding the longest sequence of same elements
        for (int i = 0; i < numbers.Length; i++)
        {
            counter = 1;
            for (int j = i; j < numbers.Length - 1; j++)
            {
                if (numbers[j] == numbers[j + 1])
                {
                    counter++;
                }
                else
                {
                    break;
                }
                currentSequence = counter;
            }

            //Checking if the currentSequence is longer than the bestSequence.
            //And getting the start position of the sequence(bestIndex)
            if (bestSequence < currentSequence)
            {
                bestSequence = currentSequence;
                bestIndex = i;
            }
        }

        Console.WriteLine(bestSequence);
    }
}

