using System;

class Program
{
    static void Main(string[] args)
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        int bestRow = 0;
        int bestCol = 0;
        int bestSum = int.MinValue;
        int sum = 0;
        int[,] matrix = new int[row, col];

        if (row >= 3 && col >= 3)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("matrix[{0},{1}] = ",i,j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Clear();
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write("{0} ",matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            for (int curRow = 0; curRow < matrix.GetLength(0) - 2; curRow++)
            {
                sum = 0;
                for (int curCol = 0; curCol < matrix.GetLength(1) - 2; curCol++)
                {
                    sum = matrix[curRow, curCol] + matrix[curRow, curCol + 1] + matrix[curRow, curCol + 2] +
                          matrix[curRow + 1, curCol] + matrix[curRow + 1, curCol + 1] + matrix[curRow + 1, curCol + 2] +
                          matrix[curRow + 2, curCol] + matrix[curRow + 2, curCol + 1] + matrix[curRow + 2, curCol + 2];
                    if (bestSum < sum)
                    {
                        bestSum = sum;
                        bestCol = curCol;
                        bestRow = curRow;
                    }
                    Console.WriteLine(sum);
                    Console.WriteLine(bestSum);
                }
            }

            Console.WriteLine("{0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
            Console.WriteLine("{0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
            Console.WriteLine("{0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
        }
        else
        {
            Console.WriteLine("Invalid inaput the row and col of the matrix should more or equal to 3.");
        }
    }
}

