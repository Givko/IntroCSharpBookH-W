using System;

class FindHypotenuse
{
    static void Main()
    {
        double a = int.Parse(Console.ReadLine());
        double b = int.Parse(Console.ReadLine());
        double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        Console.WriteLine(c);
    }
}