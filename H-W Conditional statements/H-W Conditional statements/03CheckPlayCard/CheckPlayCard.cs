using System;

class CheckPlayCard
{
    static void Main()
    {
        Console.Write("Enter card: ");
        string card = Console.ReadLine();

        if (card == "A" || card == "K" || card == "Q" || card == "J" || card == "10" || card == "9" || card == "8" ||
            card == "7" || card == "6" || card == "5" || card == "4" || card == "3" || card == "2")
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

