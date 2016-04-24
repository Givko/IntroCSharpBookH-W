using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_3_numbers
{
    class sum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            double a=double.Parse(Console.ReadLine());
            Console.Write("Enter number :");
            double b=double.Parse(Console.ReadLine());
            Console.Write("Enter number :");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} + {2} = {3}",a,b,c,a+b+c);
            
        }
    }
}
