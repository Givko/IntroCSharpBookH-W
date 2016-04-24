using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingMatrix2
{
    class PrintingMatrix2
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int[] numbers = new int[size * size];
            int index = 0;

            for (int i = 0; i < size * size; i++)
            {
                numbers[i] = i + 1;
            }

            for (int i = 0; i < size; i++)
            {

                if (i % 2 == 0)
                {
                    for (int j = 0; j < size; j++)
                    {
                        matrix[j, i] = numbers[index];
                        index++;
                    }
                }
                else if (i % 2 == 1)
                {
                    for (int j = size - 1; j >= 0; j--)
                    {
                        matrix[j, i] = numbers[index];
                        index++;
                    }
                }


            }


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0, -4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

//Same probram without using a two dimensional array
//int n = int.Parse(Console.ReadLine());  
//            int[] matrix = new int[n * n];
//            int posX = 0;
//            int posY = 0;

//            //Counter counts on which row and which col we are
//            int counterRow = 0;
//            int counterCol = 1;

//            //Gets the value direction 0 is up 1 is down
//            int direction = 0;

//            for (int i = 0; i < matrix.Length; i++)
//            {
//                matrix[i] = i + 1;
//            }

//            Console.Clear();

//            //Printing the matrix
//            for (int i = 0; i < n * n; i++)
//            {               
//                //Checkig if we have reached the end of the col(which is the n-th row)
//                if (counterRow / n == 1)
//                {
//                    counterCol += 1;
//                }

//                //Getting the direction
//                direction = counterCol % 2;

//                //If we have reached the end of the col we move the position of the cursor
//                //to the right print the next number and start counting the rows again starting from 0
//                if (counterRow==n)
//                {
//                    counterRow = 0;
//                    posX+=4;
//                    Console.SetCursorPosition(posX, posY);
//                    Console.Write(matrix[i]);
//                    counterRow++;
//                    continue;
//                }

//                //Checking which is the direction if the directio is 0 we go up if it is 1 we go down
//                switch (direction)
//                {
//                    case 0:
//                        posY--;
//                        break;
//                    case 1:
//                        posY++;
//                        break;                    
//                }

//                //We set the cursor position and printing the next number from the array
//                Console.SetCursorPosition(posX, posY); 
//                Console.Write(matrix[i]);

//                //Counting the row
//                counterRow++;

//            }

//            //Setting the cursor position below the matrix
//            Console.SetCursorPosition(0, n + 2);