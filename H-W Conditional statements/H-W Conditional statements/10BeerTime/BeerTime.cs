using System;

class BeerTime
{
    static void Main()
    {
        string s = Console.ReadLine();
        DateTime time;
        DateTime beerBeginning = DateTime.Parse("1:00 PM");
        DateTime beerEnding = DateTime.Parse("3:00 AM");
        DateTime midnight = DateTime.Parse("00:00");

        if (DateTime.TryParse(s, out time))
        {
            Console.WriteLine(time);
            if ((time.TimeOfDay >= beerBeginning.TimeOfDay && time.TimeOfDay >= midnight.TimeOfDay) || (time.TimeOfDay < beerEnding.TimeOfDay && time.TimeOfDay > midnight.TimeOfDay))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}

