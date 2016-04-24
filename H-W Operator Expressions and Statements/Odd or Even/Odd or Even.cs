using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even
{
    class oddoreven
    {
        static void Main()
        {
            
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine(n%2== 0 ? "Even" : "Odd");

            /*if(n % 2 == 0)
           {

               Console.WriteLine("Even");
           }
           else
           {
               Console.WriteLine("odd");

           }*/
           

        }
    }
}
