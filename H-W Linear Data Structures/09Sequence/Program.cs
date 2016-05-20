using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int current = int.Parse(Console.ReadLine());
            Queue<int> sequence = new Queue<int>();
            sequence.Enqueue(current);

            for (int i = 0; i < 50; i++)
            {
                current = sequence.Dequeue();
                sequence.Enqueue(current + 1);
                sequence.Enqueue(2 * current + 1);
                sequence.Enqueue(current + 2);
                Console.Write(" {0}",current);
            }
        }
    }
}
