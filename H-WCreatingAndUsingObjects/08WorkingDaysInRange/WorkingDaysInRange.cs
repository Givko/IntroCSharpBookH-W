using System;
using System.Linq;
class WorkingDaysInRange
{
    static void Main()
    {
        DateTime endDate = new DateTime(2015, 12, 31);
        DateTime startDate = new DateTime(2015, 1, 1);
        int workingDays = 0;

        DateTime[] holidays = new DateTime[] 
        {
            new DateTime(2015,1,1),
            new DateTime(2015,3,3),
            new DateTime(2015,5,24),
            new DateTime(2015,9,6),
            new DateTime(2015,12,24),
            new DateTime(2015,12,31)
        };

        DateTime[] workingSaturdays = new DateTime[] 
        {
            new DateTime(2015,3,12)
        };

        for (DateTime date = startDate ; date <= endDate; date = date.AddDays(1))
        {
            if (date.DayOfWeek.ToString() != "Sunday" && (!workingSaturdays.Contains(date.Date)) && (!holidays.Contains(date.Date)))
            {
                workingDays++;
                
            }
        }
        Console.WriteLine(workingDays);
    }
}

