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
            for (ulong i = 0; i < 10000000; i++)
            {
                IsPrime(i);
            }
        }
        private static void IsPrime(ulong num)
        {
            bool IsPrime = true;
            if (num >= 2)
            {
                for (uint i = 2; i <= Math.Sqrt(num); i++)
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
            if (IsPrime)
            {
                Console.Write("{0},",num);
            }

        }
    }
}
