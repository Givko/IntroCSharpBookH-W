using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare_float_numbers
{
    class compare
    {
        static void Main()
        {
            double a;
            double b;
            double eps = 0.000001d;
            bool c;
            Console.WriteLine("Enter the first number: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            b = double.Parse(Console.ReadLine());
            
            if (a < b)
                {
                    c = b - a < eps;
                    Console.WriteLine(c);
                }
                        else
                            {
                                c = a - b < eps;
                                Console.WriteLine(c);

                            }
                
    
        }

    }
}