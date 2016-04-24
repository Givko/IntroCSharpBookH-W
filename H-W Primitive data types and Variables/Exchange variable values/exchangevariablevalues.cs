using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_variable_values
{
    class exchangevariablevalues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int c;
            Console.WriteLine(a + "\n" + b+"\n");
            c = a;
            a = b;
            b = c;
            Console.WriteLine(a + "\n" + b);
       
        }
    }
}
