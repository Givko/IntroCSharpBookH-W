using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_long_sequence
{
    class Longsequence
    {
        static void Main(string[] args)
        {
            int a = -1;
            int one = 1;
            
            for (int i = 2; i < 1002; i++)
            {
                a = -a + one;
                one = -one;
                Console.WriteLine(a);
            }
        }
    }
}
