using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12DymanicStack
{
    class TestDynamicStack
    {
        static void Main(string[] args)
        {
            DymanicStack<int> numbers = new DymanicStack<int>();
            for (int i = 0; i < 50; i++)
            {
                numbers.Push(i);
            }
            numbers.Clear();
            Console.ReadKey(true);
        }
    }
}
