using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pr._25_27.Fraction
{
    class FractionTest
    {

        static void Main(string[] args)
        {

            string firstInputLine = Console.ReadLine();
            string secondInputLine = Console.ReadLine();

            Fraction a = Fraction.Parse(firstInputLine);

            Fraction b = Fraction.Parse(secondInputLine);

            if ((a != null) && (b != null))
            {
                a.ToString();
                Console.WriteLine();
                b.ToString();
                Console.WriteLine();

                Fraction c = a + b;

                c.ToString();
                Console.Write(c.DecimalValue);

                Fraction k = a - b;
                Console.WriteLine();
                k.ToString();
                Console.WriteLine(k.DecimalValue);
            }


        }
    }
}
