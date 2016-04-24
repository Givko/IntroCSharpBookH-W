using System;

class MatrixOfNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        //Prints out a square matrix
        for (int row = 1; row <= n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,2}", col + row);
            }
            Console.WriteLine();
        }
    }
}

