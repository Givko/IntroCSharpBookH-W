using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Inside_a_circle__outside_a_rectangle
{
    class InCircleOutRect
    {
        static void Main()
        {
            Console.WriteLine("enter x: ");
            
                double x = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter y :");
            
                double y = double.Parse(Console.ReadLine());
            
            bool InCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5;
            
            bool Inrect = x > 5 || x < -1 || y > 1 || y < -1;
            
            Console.WriteLine( InCircle == true && Inrect == true ? "yes" : "no");

            

        }
    }
}
