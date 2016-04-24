using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise_Extract_Bit_3
{
    class extractbit3
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int move = n >> 3;
            int bit = move & 1;
            Console.WriteLine(bit);
        }
    }
}
