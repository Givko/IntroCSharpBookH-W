using System;

class SpiralMatrix
{
    static void Main()
    {
        int sizeOfMatrix = int.Parse(Console.ReadLine());
        int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
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

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0} ", matrix[i, j].ToString().PadRight((sizeOfMatrix * sizeOfMatrix).ToString().Length + 1));
            }
            Console.WriteLine();
        }

    }
}

