using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demos
{
    class Program
    {

        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] arrnumbers = numbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] chisla = new int[arrnumbers.Length];
            int swap;
            
            for (int i = 0; i < arrnumbers.Length; i++)
            {
                chisla[i] = int.Parse(arrnumbers[i]);
                //Console.WriteLine(chisla[i]);
            }
            for (int i = 0; i < chisla.Length; i++)
            {
                for (int sort = 1; sort < chisla.Length; sort++)
                {
                    if (chisla[sort] < chisla[sort - 1])
                    {
                        swap = chisla[sort];
                        chisla[sort] = chisla[sort - 1];
                        chisla[sort - 1] = swap;
                    }
                }
            }
            for (int i = 0; i < chisla.Length; i++)
            {
                Console.WriteLine(chisla[i]);
            }
        }
    }
}
