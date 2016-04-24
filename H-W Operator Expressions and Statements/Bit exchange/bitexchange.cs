using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_exchange
{
    class bitexchange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            long number = long.Parse(Console.ReadLine());

            long mask1 = number & 7 << 3;
            long mask2 = number & 7 << 24;
                
            //Console.WriteLine(number);
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
                number = number & ~(7 << 3);
                number = number & ~(7 << 24);
                number = number | (mask1 << 21);
                number = number | (mask2 >> 21);
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine(number);
            


        }
    }
}
