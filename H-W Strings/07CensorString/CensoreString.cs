using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07CensorString
{
    class CensoreString
    {
        static void Main()
        {
            string text = Console.ReadLine();
            if (text.Length > 20)
            {
                Console.WriteLine("The text must be 20 or less symbols!! Yours is {0} symbols",text.Length);
            }
            else
            {
                CensorText(text);
            }
        }

        private static void CensorText(string text)
        {
            Console.WriteLine(text.PadRight(20,'*'));
        }
    }
}
