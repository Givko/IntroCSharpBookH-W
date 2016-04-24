using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Perimeter_and_Area
{
    class circleperimeter
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("The perimeter of the curcle with radius {0:0.00} is:{1:0.00}  ", r , 2*Math.PI*r);
        }
    }
}
