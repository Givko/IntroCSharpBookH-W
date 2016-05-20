using System;
using System.Collections.Generic;
using System.Linq;

class SubSequenceOfEqualElements
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> longestSeq = FindLongestSequenceOfEqualElements(numbers);

        Console.WriteLine(string.Join(", ",longestSeq));
    }

    private static List<int> FindLongestSequenceOfEqualElements(List<int> numbers)
    {
        int count = 1;
        int longestSequence = 1;
        int startIndex = 0;
        List<int> sequence = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            count = 1;
            for (int j = i; j < numbers.Count - 1; j++)
            {
                if (numbers[j] != numbers[j + 1])
                {
                    break;
                }
                count++;
            }

            if (count > longestSequence)
            {
                longestSequence = count;
                startIndex = i;
            }
        }

        while (longestSequence != 0)
        {
            sequence.Add(numbers[startIndex]);
            longestSequence--;
        }

        return sequence;
    }
}

