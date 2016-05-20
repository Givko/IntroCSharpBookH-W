using System.Collections.Generic;

namespace _05RemoveNegativeNumbers
{
    static class ListExtensionMethods
    {
        public static void RemoveNegativeNumbers(this IList<int> numbers)
        {
            int count = numbers.Count;
            List<int> negativeNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    negativeNumbers.Add(numbers[i]);
                }
            }

            for (int i = 0; i < negativeNumbers.Count; i++)
            {
                numbers.Remove(negativeNumbers[i]);
            }
        }
    }
}
