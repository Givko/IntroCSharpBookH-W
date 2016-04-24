using System;

class ReadNumberInRange
{
    static void ReadNumber(int start, int end)
    {
        Random numberGenerator = new Random();
        int number = numberGenerator.Next(1, 101);
        for (int i = 0; i < 10; i++)
        {
            number = numberGenerator.Next(1, 101);
            if (number < start || number > end)
            {
                OverflowException ex = new OverflowException("The number was not in range.");
                Console.WriteLine(ex.Message);
            }
            else
            {
                Console.WriteLine("ok");
            }
        }
    }
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number in the range [{0},{1}]",start,end);
        ReadNumber(start, end);
    }
}

