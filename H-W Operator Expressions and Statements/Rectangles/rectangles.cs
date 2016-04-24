using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class rectangles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter widnth:");
            double windth = double.Parse(Console.ReadLine());            
            Console.WriteLine("Enter height:"); 
            double height= double.Parse(Console.ReadLine());
            Console.WriteLine("The perimiter= " + (2*windth + 2*height) +" The area = " + windth*height );
        }
    }
}
