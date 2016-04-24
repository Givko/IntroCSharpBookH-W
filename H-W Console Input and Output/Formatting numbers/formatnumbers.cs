using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatting_numbers
{
    class formatnumbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("|{0,-10:X}|" + Convert.ToString(a,2).PadLeft(32,'0') + "|{1,10:0.00}|{2,-10:0.000}",a,b,c);
        }
    }
}
