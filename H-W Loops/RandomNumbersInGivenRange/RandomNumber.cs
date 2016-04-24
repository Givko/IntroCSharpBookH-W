using System;

class RandomNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the start of the range: ");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the end of the range: ");
        int max = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of numbers you want to be generated: ");
        int num = int.Parse(Console.ReadLine());
        Random r = new Random();
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(r.Next(min,max));
        }
    }
}

