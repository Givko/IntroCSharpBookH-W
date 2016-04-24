using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bits_Exchange_1
{
    class bitaxchange
    {
        static void Main()
        {
        
                Console.WriteLine("enter number: ");
            
            uint number = uint.Parse(Console.ReadLine());

            Console.WriteLine(new String('-', 40));

            uint mask = 7 << 3;
            
            uint d3_4_5 = (number & mask) >> 3;
            
            uint newmask = 7 << 24;
            
            uint d24_25_26 = (number & newmask) >> 24;
            
            uint newnumber1 = number & ~mask;
            
                Console.WriteLine(Convert.ToString(number,2).PadLeft(32,'0'));
            
                Console.WriteLine(Convert.ToString(~mask, 2).PadLeft(32, '0'));   
            
                Console.WriteLine(Convert.ToString(newnumber1, 2).PadLeft(32, '0'));
            
                Console.WriteLine(new String('-',40));
            
                Console.WriteLine(Convert.ToString(newnumber1, 2).PadLeft(32, '0'));
            
            newnumber1 = newnumber1 | (d24_25_26 << 3); 
            
                Console.WriteLine(Convert.ToString(d24_25_26<<3, 2).PadLeft(32, '0'));
            
                Console.WriteLine(Convert.ToString(newnumber1, 2).PadLeft(32, '0'));
            
                Console.WriteLine(new String('-',40));
            
                Console.WriteLine(Convert.ToString(newnumber1, 2).PadLeft(32, '0'));
            
            newnumber1 = newnumber1 & ~newmask;
            
                Console.WriteLine(Convert.ToString(~newmask, 2).PadLeft(32, '0'));
            
                Console.WriteLine(Convert.ToString(newnumber1, 2).PadLeft(32, '0'));
            
                Console.WriteLine(new String('-',40));
            
                Console.WriteLine(Convert.ToString(newnumber1, 2).PadLeft(32, '0'));
            
            newnumber1 = newnumber1 | (d3_4_5 << 24);
            
                Console.WriteLine(Convert.ToString(d3_4_5<<24, 2).PadLeft(32, '0'));
            
                Console.WriteLine(Convert.ToString(newnumber1, 2).PadLeft(32, '0'));

                Console.WriteLine(new String('-',40));
            
                Console.Write("the new number is: ");
            
                Console.WriteLine(newnumber1);
        }

    }
}