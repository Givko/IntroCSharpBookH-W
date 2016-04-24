using System;

class RandomNumber
{
    static void Main()
    {
        Random rand = new Random();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0}",rand.Next(100,201));
        }
    }
}

