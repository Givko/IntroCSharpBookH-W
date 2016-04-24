using System;

class DayToday
{
    static void Main()
    {
        DateTime day = new DateTime();
        day = DateTime.Now;
        Console.WriteLine(day.DayOfWeek);
    }
}

