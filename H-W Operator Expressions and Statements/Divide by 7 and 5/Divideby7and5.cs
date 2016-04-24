using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_by_7_and_5
{
    class Divideby7and5
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n%5==0 && n%7==0);

        }
    }
}
