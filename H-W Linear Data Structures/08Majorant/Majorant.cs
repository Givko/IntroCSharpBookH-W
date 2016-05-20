using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Majorant
{
    class Majorant
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int occurences = 1;
            int majorant = numbers.Count / 2 + 1;
            int? majorantNumber = null;

            for (int i = 0; i < numbers.Count; i++)
            {
                occurences = 1;
                for (int j = i; j < numbers.Count - 1; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        occurences++;
                    }
                }
                if (occurences >= majorant)
                {
                    majorantNumber = numbers[i];
                    break;
                }
            }

            if (majorantNumber != null)
            {
                Console.WriteLine(majorantNumber);
            }
            else
            {
                Console.WriteLine("The majorant does not exist!");
            }
        }
    }
}
