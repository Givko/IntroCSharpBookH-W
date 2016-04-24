using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modify_a_bit_at_given_Position
{
    class modifybit
    {
        static void Main()
        {
            
            //    Console.WriteLine(" enter num : ");
            
            //int num = int.Parse(Console.ReadLine());
            
            //    Console.WriteLine("enter paosition: ");
            
            //int position = int.Parse(Console.ReadLine());
            
            //    Console.WriteLine("enter value 1 or 0:");
            
            //int val = int.Parse(Console.ReadLine());
            
            //if (val == 0)
            //{
            //    int mask = ~(1 << position);
            //    Console.WriteLine(mask&num);
            //}
            //else
            //{
            //    int mask = 1 << position;
            //    Console.WriteLine(mask|num);

            //}
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter bit possition: ");
            int position = int.Parse(Console.ReadLine());

            Console.Write("Enter value 1 or 0: ");
            int value = int.Parse(Console.ReadLine());


                if (value==0)
                    {
                        int mask = ~(1 << position);
                    
                           Console.WriteLine(number&mask);
                    }
                else
                    {
                        int mask = 1 << position;
                        Console.WriteLine(number|mask);
                    }

        }
    }
}














