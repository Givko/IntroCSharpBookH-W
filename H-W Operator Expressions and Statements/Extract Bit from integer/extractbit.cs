using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Bit_from_integer
{
    class extractbit
    {
        static void Main()
        {

                Console.WriteLine("enter number: ");
            int n=int.Parse(Console.ReadLine());
            
                Console.WriteLine("enter position: ");
            int p=int.Parse(Console.ReadLine());
            int move = n >> p;
            int bit = move & 1;
            Console.WriteLine(bit);

        }
    }
}
