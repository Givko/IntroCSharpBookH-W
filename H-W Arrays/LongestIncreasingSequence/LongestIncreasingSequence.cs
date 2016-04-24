using System;



class LongestIncreasingSequence
{
    static void Main(string[] args)
    {
        Console.Write("Enter length of the array: ");
        int length = int.Parse(Console.ReadLine());
        double[] numbers = new double[length];
        int currentSequence = 0;
        int bestSequence = 0;
        int counter = 0;
        int bestIndex = 0;

        //Input elements in array
         for (int i = 0; i < numbers.Length; i++)
         {
             Console.Write("Enter the {0} element in the array.", i + 1);
             numbers[i] = double.Parse(Console.ReadLine());
         }

        //Finding the longest increasing subsequence
        for (int i = 0; i < numbers.Length; i++)
        {
            counter = 0;
            for (int j = i; j < numbers.Length-1; j++)
            {
                if (numbers[j] < numbers[j+1])
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

        //Printing the bestSequence        
        Console.Write("The longest sequence in the array is:{ ");
        while (bestSequence >= 0)
        {
            Console.Write(" {0,2},", numbers[bestIndex]);
            bestSequence--;
            bestIndex++;
        }
        Console.WriteLine("}");
    }
}

