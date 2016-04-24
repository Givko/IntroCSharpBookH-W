using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace age_after_10_years
{
    class vuzrast
    {
        static void Main()
        {
            int newage;
            int age;
            
            age = int.Parse(Console.ReadLine());
            newage = age + 10;
            Console.Clear();
            Console.WriteLine(age);
            Console.WriteLine(newage);
        }
    }
}
