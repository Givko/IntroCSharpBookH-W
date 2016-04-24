using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Digit_number
{
    class fourdigitnumber
    {
        static void Main()
        {
            int fourdigitnumber = int.Parse(Console.ReadLine());
            
            int thousands = fourdigitnumber / 1000;
            int hundreds = ( fourdigitnumber % 1000 ) / 100;
            int tenths = ( ( fourdigitnumber % 1000 ) % 100 ) / 10;
            int ones = ( ( fourdigitnumber % 1000 ) % 100 ) % 10;
            
                Console.WriteLine("The sum of the digits is: " + (thousands+hundreds+tenths+ones));
   
                Console.WriteLine("Your number backwards is: " + ones + tenths + hundreds + thousands);
            
                Console.WriteLine("Last digit in furst position: " + ones + thousands + hundreds + tenths);
            
                Console.WriteLine("Exchange the second and third digit: " + thousands + tenths + hundreds + ones);
        }
    }
}
