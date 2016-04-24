using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_number_check
{
    class primenumber
    {
        static void Main()
        {
        
        /*int n = int.Parse(Console.ReadLine());
            if (n <= 3) 
            {
                Console.WriteLine(n>1); 
             }
            else if (n % 2 == 0 || n % 3 == 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                for (int i = 5; i * i <= n; i = i + 6)
                {
                    if (n % i == 0 || n % (i + 2) == 0)
                    {
                        Console.WriteLine("false");
                    }
                }
                Console.WriteLine("true");
            }*/
            
            //int prime = int.Parse(Console.ReadLine());
            //bool isprime = true;
            //if(prime<2)
            //{
            //    isprime = false;
            //}
            //else
            //{
            //    for(int i =2;i<prime;i++)
            //    {
            //        if (prime%i==0)
            //        {
            //            isprime = false;
            //        }
            //    }

            //}
            //Console.WriteLine(isprime);


            bool isprime=true;
            int number = int.Parse(Console.ReadLine());
                if (number >= 2)
                    {
                        for (int i = 2; i <= Math.Sqrt(number); i++)
                        {
                            if (number % i == 0)
                            {
                                isprime = false;
                            }
                        }
                    }
                else
                    {
                        isprime = false;
                    }
            Console.WriteLine(isprime);  
        }
    }
}
