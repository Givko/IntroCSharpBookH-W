using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07NumberAccurences
{
    class NumberOccurences
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            SortedDictionary<int, int> numberOccurences = new SortedDictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numberOccurences.ContainsKey(numbers[i]))
                {
                    numberOccurences[numbers[i]] += 1;
                }
                else
                {
                    numberOccurences.Add(numbers[i], 1);
                }
            }

            foreach (var num in numberOccurences)
            {
                Console.WriteLine("{0}->{1}",num.Key,num.Value);
            }
        }
    }
}
