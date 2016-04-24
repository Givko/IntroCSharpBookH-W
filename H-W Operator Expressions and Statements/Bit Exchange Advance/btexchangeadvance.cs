using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Exchange_Advance
{
    class bitexchangeadvance
    {
        static void Main(string[] args)
        {
            uint mask = 0;

            Console.Write("Enter number: ");
            uint number = uint.Parse(Console.ReadLine());

            uint p;

            Console.Write("Enter start bit: ");
            int startposition = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second start bit(it has to be bigger than the first): ");
            int secstartposition = int.Parse(Console.ReadLine());

            Console.Write("Enter number of bits to swap: ");
            int numofbits = int.Parse(Console.ReadLine());

            if (Math.Max(startposition, secstartposition) + numofbits > 32 || Math.Min(startposition, secstartposition) < 0)
            {
                Console.WriteLine("out of range");
            }

            else if ((startposition < secstartposition && startposition + numofbits - 1 >= secstartposition) || (startposition > secstartposition && secstartposition + numofbits - 1 > startposition) || startposition == secstartposition)
            {
                Console.WriteLine("overlapping");
            }

            else if (startposition < secstartposition)
            {
                uint firstbits;
                uint secondbits;

                for (uint i = 0; i <= numofbits - 1; i++)
                {
                    p = (uint)Math.Pow(2, i);
                    mask = mask + p;
                    //Console.WriteLine(Convert.ToString(mask,2).PadLeft(32,'0'));
                }

                Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
                firstbits = number & (mask << startposition);
                Console.WriteLine(Convert.ToString(firstbits, 2).PadLeft(32, '0'));
                secondbits = number & (mask << secstartposition);
                Console.WriteLine(Convert.ToString(secondbits, 2).PadLeft(32, '0'));
                number = number & ~(mask << startposition);
                number = number & ~(mask << secstartposition);
                number = number | (firstbits << (secstartposition - startposition));
                number = number | (secondbits >> (secstartposition - startposition));
                Console.WriteLine(number);
            }
            else
            {
                uint firstbits;
                uint secondbits;

                for (uint i = 0; i <= numofbits - 1; i++)
                {
                    p = (uint)Math.Pow(2, i);
                    mask = mask + p;
                    //Console.WriteLine(Convert.ToString(mask,2).PadLeft(32,'0'));
                }

                Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
                firstbits = number & (mask << secstartposition);
                Console.WriteLine(Convert.ToString(firstbits, 2).PadLeft(32, '0'));
                secondbits = number & (mask << startposition);
                Console.WriteLine(Convert.ToString(secondbits, 2).PadLeft(32, '0'));
                number = number & ~(mask << startposition);
                number = number & ~(mask << secstartposition);
                number = number | (firstbits << (startposition - secstartposition));
                number = number | (secondbits >> (startposition - secstartposition));
                Console.WriteLine(number);
            }



        }
    }
}
