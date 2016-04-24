using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_circle
{
    class pointincircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the circle is with coordinates K({0,0},2)");
            Console.Write("Enter coordinate X: ");
            int Xpoint = int.Parse(Console.ReadLine());
            Console.Write("Enter coordinate Y:");
            int Ypoint = int.Parse(Console.ReadLine());
            Console.WriteLine((Xpoint - 0) * (Xpoint - 0) + (Ypoint - 0) * (Ypoint - 0)>2*2 ? "Is outside" : "Is inside");
        }
    }
}