using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Trapezoid
    {
        static void Main()
        {
                Console.WriteLine("Enter a: ");
           
            double a=double.Parse(Console.ReadLine());
            
                Console.WriteLine("Enter b: ");
            
            double b=double.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter height: ");
            
            double height=double.Parse(Console.ReadLine());
            
                Console.WriteLine("Area of Trapezoid is: " + (a+b)/2*height);
        }
    }
}
