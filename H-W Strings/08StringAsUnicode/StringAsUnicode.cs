using System;
using System.Text;

namespace _08StringAsUnicode
{
    class StringAsUnicode
    {
        static void Main()
        {
            string text = Console.ReadLine();
            
            foreach (char letter in text)
            {
                Console.Write("\\u{0:X4}", (int)letter);

            }
            Console.WriteLine();
        }
    }
}
