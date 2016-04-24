using System;

class TimeElapsed
{
    static void Main()
    {
        double timeSinceSysStarted = ((Environment.TickCount / 1000.0) / 60) / 60;
        Console.WriteLine("{0:F}", timeSinceSysStarted);
    }
}