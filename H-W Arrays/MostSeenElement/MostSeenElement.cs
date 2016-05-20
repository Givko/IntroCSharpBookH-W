using System;

class MostSeenElement
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int[length];
        int timesSeenCurElement = 0;
        int timesSeenMostSeenElement = 0;
        int counter = 0;
        int indexOfMostSeenElement = 0;

        //Input elements in array
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        //Finding the most seen element in the array 
        for (int i = 0; i < numbers.Length; i++)
        {
            counter = 0;
            for (int j = i; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    counter++;
                }
                timesSeenCurElement = counter;
            }

            //Checking if the currentSequence is longer than the bestSequence.
            //And getting the start position of the sequence(bestIndex)
            if (timesSeenMostSeenElement < timesSeenCurElement)
            {
                timesSeenMostSeenElement = timesSeenCurElement;
                indexOfMostSeenElement = i;
            }
        }

        Console.WriteLine("{0} ({1} times)", numbers[indexOfMostSeenElement], timesSeenMostSeenElement);
    }
}