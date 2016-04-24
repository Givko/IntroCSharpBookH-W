using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMatrix3
{
    class PrintMatrix3
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int[] numbers = new int[size * size];
            int index = 0;
            int row = 0;
            int col = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }


            InsertInMatrixToMainDiagonal(matrix, size, row, col,ref index, numbers);
            InsertInMatrixAfterMainDiagonal(matrix, size, row, col,ref index, numbers);
            PrintingMatrix(matrix, size);

        }

        private static void InsertInMatrixToMainDiagonal(int[,] matrix, int size, int row, int col,ref int index, int[] numbers)
        {
            for (int i = size - 1; i >= 0; i--)
            {
                // Inserts numbers in the matrix til the main diagonal including
                for (int j = 0; j < size; j++)
                {
                    if (j == 0)
                    {
                        row = i;
                        col = j;
                    }

                    matrix[row, col] = numbers[index];
                    index++;
                    if (row == size - 1)
                    {
                        break;
                    }
                    row++;
                    col++;
                }

            }    
        }

        private static void PrintingMatrix(int[,] matrix, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0, -3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void InsertInMatrixAfterMainDiagonal(int[,] matrix, int size, int row, int col,ref int index, int[] numbers)
        {


            // instering numbers after the main diagonal
            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == 0)
                    {
                        col = i;
                        row = j;
                    }

                    matrix[row, col] = numbers[index];
                    index++;
                    if (col == size - 1)
                    {
                        break;
                    }
                    row++;
                    col++;
                }
            }
        }

    }
}
