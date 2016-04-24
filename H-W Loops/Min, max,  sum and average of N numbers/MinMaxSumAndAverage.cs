using System;

class MinMaxSumAndAverage
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int min = new int();
        int max = new int();
        double sum = new double();
        double average = new double();

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());

            if (min == 0)
            {
                min = numbers[i];
            }
            else if (min > numbers[i])
            {
                min = numbers[i];
            }
            if (max == 0)
            {
                max = numbers[i];
            }
            else if (max < numbers[i])
            {
                max = numbers[i];
            }
            sum += numbers[i];
        }
        average = sum / n;
        Console.WriteLine("min = {0}, max = {1}, sum = {2}, average {3}", min, max, sum, average);
    }
}

