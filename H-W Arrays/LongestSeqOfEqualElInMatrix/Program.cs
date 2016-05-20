using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    const int CELL_FORBIDDEN = int.MinValue;
    static int dimension;
    static public int[,] matrix;

    private static void InputMatrix(int[] rowCol)
    {
        for (int i = 0; i < rowCol[0]; i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            for (int j = 0; j < line.Length; j++)
            {
                matrix[i, j] = int.Parse(line[j]);
            }
        }
    }

    public static void Main(string[] args)
    {
        int[] rowCol = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        dimension = Math.Max(rowCol[0],rowCol[1]);
        matrix = new int[dimension, dimension];
        InputMatrix(rowCol);

        int maxDfsCount = int.MinValue;
        for (int i = 0; i < dimension; i++)
        {
            for (int j = 0; j < dimension; j++)
            {
                if (matrix[i, j] != CELL_FORBIDDEN)
                {
                    int currentDfsCount = DFS(i, j);
                    maxDfsCount = Math.Max(maxDfsCount, currentDfsCount);
                }
            }
        }
        Console.WriteLine(maxDfsCount);
    }

    public class Pair
    {
        public int x, y;
        public Pair()
        {
            x = y = 0;
        }
        public Pair(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public static int DFS(int x, int y)
    {
        Stack<Pair> stackForDFS = new Stack<Pair>();
        stackForDFS.Push(new Pair(x, y));
        int result = 0;
        while (stackForDFS.Count > 0)
        {
            Pair coordinates = stackForDFS.Pop();
            int elementOnCoordinates = matrix[coordinates.x, coordinates.y];
            if (elementOnCoordinates == CELL_FORBIDDEN)
            {
                continue;
            }

            result++;

            matrix[coordinates.x, coordinates.y] = CELL_FORBIDDEN;

            Pair leftCoordinates = new Pair(coordinates.x, coordinates.y - 1);
            if (IsValidCoordinates(leftCoordinates) && elementOnCoordinates == matrix[leftCoordinates.x, leftCoordinates.y])
            {
                stackForDFS.Push(leftCoordinates);
            }

            Pair rightCoordinates = new Pair(coordinates.x, coordinates.y + 1);
            if (IsValidCoordinates(rightCoordinates) && elementOnCoordinates == matrix[rightCoordinates.x, rightCoordinates.y])
            {
                stackForDFS.Push(rightCoordinates);
            }

            Pair upCoordinates = new Pair(coordinates.x - 1, coordinates.y);
            if (IsValidCoordinates(upCoordinates) && elementOnCoordinates == matrix[upCoordinates.x, upCoordinates.y])
            {
                stackForDFS.Push(upCoordinates);
            }

            Pair downCoordinates = new Pair(coordinates.x + 1, coordinates.y);
            if (IsValidCoordinates(downCoordinates) && elementOnCoordinates == matrix[downCoordinates.x, downCoordinates.y])
            {
                stackForDFS.Push(downCoordinates);
            }
        }
        return result;
    }
    public static bool IsValidCoordinates(Pair coordinates)
    {
        bool result = (coordinates.x >= 0) && (coordinates.x < dimension) && (coordinates.y >= 0) && (coordinates.y < dimension);
        return result;
    }
}
