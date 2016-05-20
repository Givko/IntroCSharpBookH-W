using System;

class AreaOfTriangle
{
    static void Main()
    {

        double a = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        CalcArea(a, a, c);

    }

    private static void CalcArea(double cathetus1, double cathetus2, double hypotenuse)
    {
        double p = ((cathetus1 + cathetus2 + hypotenuse) / 2);
        double area = Math.Sqrt(p * (p - cathetus1) * (p - cathetus2) * (p - hypotenuse));
        Console.WriteLine("{0:0.00}", Math.Ceiling(area));
    }
    private static void CalcArea(double side1, double side2, float angle)
    {
        angle *= (float)(Math.PI / 180);
        double area = (side1 * side2 * Math.Sin(angle)) / 2;
        Console.WriteLine("{0:0.00}", Math.Ceiling(area));
    }
    private static void CalcArea(double side, double height)
    {
        double area = (side * height) / 2;
        Console.WriteLine("{0:0.00}", Math.Ceiling(area));
    }
    private static void Menu()
    {
        Console.WriteLine("1. Calculate area using 3 sides");
        Console.WriteLine("2. Calculate area using 2 side and angle between them.");
        Console.WriteLine("3. Calculate area using 1 side and the height to it");
    }
}