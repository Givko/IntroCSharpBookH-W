using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06RemoveOddNumberOfAccurences
{
    class RemoveOddNumberOfAccurences
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Dictionary<int, int> numberAccurences = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numberAccurences.ContainsKey(numbers[i]))
                {
                    numberAccurences[numbers[i]] += 1;
                }
                else
                {
                    numberAccurences.Add(numbers[i], 1);
                }
            }

            foreach (var num in numberAccurences)
            {
                if (num.Value % 2 == 1)
                {
                    numbers.RemoveAll(n => n == num.Key);
                }
            }

            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}