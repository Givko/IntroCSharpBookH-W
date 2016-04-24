using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravitation_of_the_Moon
{
    class moongravitation
    {
        static void Main()
        {
            double Earthweight=double.Parse(Console.ReadLine());
            Console.WriteLine("Your weight on the Moon will be: " + Earthweight*(17.0/100.0));
        }
    }
}
