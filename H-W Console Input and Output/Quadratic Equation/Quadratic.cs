using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    class Quadratic
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double D = Math.Pow(b, 2) - 4 * a *c;
            double x1 = (-b + Math.Sqrt(D)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2.0 * a);
            Console.WriteLine("x1= " + x1 + "  x2= " + x2);
        }
    }
}
