using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingMatrix
{
    class PrintingMatrix
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int[] numbers = new int[size*size];
            int index = 0;
           
            for (int i = 0; i < size*size; i++)
            {
                numbers[i] = i+1;
            }


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {

                    matrix[j, i] = numbers[index];
                    index++;
                }
            }


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0, -4}",matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
           
            // Same problem without using a two dimension array
            //Console.WindowWidth = 100;
            //int n = int.Parse(Console.ReadLine());
            //int[] matrix = new int[n*n];
            //int posX = 0;
            //int posY = 0;
            //int counter = 0;

            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    matrix[i] = i + 1;
            //}

            //Console.Clear();
            //for (int i = 0; i < n * n; i++)
            //{
            //    if (counter == n)
            //    {
            //        posY = 0;
            //        Console.SetCursorPosition(posX += 4, posY);
            //        Console.Write(matrix[i]);
            //        counter = 0;
            //    }
            //    else if (i != 0)
            //    {
            //        Console.SetCursorPosition(posX, posY+=2);
            //        Console.Write(matrix[i]);
            //    }
            //    else
            //    {
            //        Console.Write(matrix[i]);
            //    }
            //    counter++;
            //}
            
            //Console.WriteLine();