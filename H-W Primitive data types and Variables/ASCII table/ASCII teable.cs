using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_table
{
    class ASCIItable
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.BufferHeight = 256;
            for (int uninumber = 0; uninumber < 255; uninumber++)
            {

                char unicode = (char)uninumber;
                if (char.IsWhiteSpace(unicode))
                {
                    Console.Write("");

                }
                else
                {
                    if (char.IsSymbol(unicode) || char.IsLetter(unicode) || char.IsNumber(unicode))
                    {
                        Console.Write(unicode + "    ");
                    }
                }
            }
                 

             
        }
    }
}
