using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_digit_7
{
    class thirddigit7
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            bool Is7 = (a / 100) % 10 == 7;
            Console.WriteLine(Is7);
            

            
        }
    }
}
