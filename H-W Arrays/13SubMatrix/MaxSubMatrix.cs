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
            char letter = char.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int[] numbers = new int[size * size];
            

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            switch (letter)
            {
                case 'a':
                    FillMatrixCase1(matrix, numbers);
                    PrintingMatrix(matrix);
                    break;
                case 'b':
                    FillMatrixCase2(matrix, numbers);
                    PrintingMatrix(matrix);
                    break;
                case 'c':
                    FillMatrixCase3(matrix, numbers);
                    PrintingMatrix(matrix);
                    break;
                case 'd':
                    FillMatrixCase4(matrix);
                    PrintingMatrix(matrix);
                    break;
                default:
                    break;
            }


        }

        private static void FillMatrixCase3(int[,] matrix, int[] numbers)
        {
            int index = 0;
            int row = 0;
            int col = 0;

            InsertInMatrixToMainDiagonal(matrix, row, col, ref index, numbers);
            InsertInMatrixAfterMainDiagonal(matrix, row, col, ref index, numbers);
        }

        private static void FillMatrixCase4(int[,] matrix)
        {
            int col = 0;
            int row = 0;
            int direction = 0;
            int side = matrix.GetLength(0);
            int[,] navigator = {
                                { 1, 0 },
                                { 0, 1 },
                                { -1, 0 },
                                { 0, -1 }
                                };
            for (int iterator = 1; iterator <= side * side; iterator++)
            {
                matrix[col, row] = iterator;
                int nextXcoord = col + navigator[direction, 0];
                int nextYcoord = row + navigator[direction, 1];
                if (nextXcoord == side || nextXcoord == -1 || nextYcoord == side || nextYcoord == -1 || matrix[nextXcoord, nextYcoord] != 0)
                {
                    direction++;
                    direction %= 4;
                }
                col += navigator[direction, 0];
                row += navigator[direction, 1];
            }
        }

        private static void FillMatrixCase1(int[,] matrix, int[] numbers)
        {
            int index = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    matrix[j, i] = numbers[index];
                    index++;
                }
            }
        }

        private static void FillMatrixCase2(int[,] matrix, int[] numbers)
        {
            int index = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                if (i % 2 == 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[j, i] = numbers[index];
                        index++;
                    }
                }
                else if (i % 2 == 1)
                {
                    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {
                        matrix[j, i] = numbers[index];
                        index++;
                    }
                }


            }


        }

        private static void InsertInMatrixToMainDiagonal(int[,] matrix, int row, int col, ref int index, int[] numbers)
        {
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                // Inserts numbers in the matrix til the main diagonal including
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        row = i;
                        col = j;
                    }

                    matrix[row, col] = numbers[index];
                    index++;
                    if (row == matrix.GetLength(0) - 1)
                    {
                        break;
                    }
                    row++;
                    col++;
                }

            }
        }

        private static void PrintingMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == matrix.GetLength(1) - 1)
                    {
                        Console.Write("{0}", matrix[i, j]);
                        continue;
                    }
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void InsertInMatrixAfterMainDiagonal(int[,] matrix, int row, int col, ref int index, int[] numbers)
        {


            // instering numbers after the main diagonal
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        col = i;
                        row = j;
                    }

                    matrix[row, col] = numbers[index];
                    index++;
                    if (col == matrix.GetLength(1) - 1)
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
