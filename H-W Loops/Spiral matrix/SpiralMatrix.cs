using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral_matrix
{
    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] numbers = new int[n,n];
            int row=0;
            int col=0;
            int direction=1;
            
            for (int i = 1; i <= n*n; i++)
            {
                numbers[row, col] = i;
                
            }

            
        }
    }
}

