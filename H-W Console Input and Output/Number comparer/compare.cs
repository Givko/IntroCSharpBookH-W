using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_comparer
{
    class compare
    {
        static void Main()
        {
            Console.Write("enter a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("enter b: ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine(a>b ? "greater {0}" : "greater {1}" , a,b);
        }
    }
}
