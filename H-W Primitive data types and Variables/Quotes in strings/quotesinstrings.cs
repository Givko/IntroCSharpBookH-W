using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotes_in_strings
{
    class quotesinstrings
    {
        static void Main(string[] args)
        {
            string withquotes = @"the ""use"" of quotations causes difficulties.";
            string withoutquotes = "the use of qutations causes difficulties.";
            Console.WriteLine(withquotes + "\n" + withoutquotes);
        }
    }
}
