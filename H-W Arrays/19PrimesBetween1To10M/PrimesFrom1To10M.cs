using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19PrimesBetween1To10M
{
    class PrimesFrom1To10M
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long biggestPrime = 0;

            for (long i = n; i >= 0; i--)
            {
                if (CheckIsNumberPrime(i))
                {
                    biggestPrime = i;
                    break;
                }
            }
            Console.WriteLine(biggestPrime);
        }

        private static bool CheckIsNumberPrime(long num)
        {
            bool IsPrime = true;
            if (num >= 2)
            {
                for (long i = (long)Math.Sqrt(num); i >= 2; i--)
                {
                    if (num % i == 0)
                    {
                        IsPrime = false;
                    }
                }
            }
            else
            {
                IsPrime = false;
            }


            return IsPrime;
        }
    }
}
