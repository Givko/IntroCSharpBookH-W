using System;

class ReadNaturalNumber
{
    static void Main()
    {
        uint number;

        try
        {
            number = uint.Parse(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            Console.WriteLine("The number you entered is not a natural number! /r/n  Do you want more detail(yes/no)?");
            string answer = Console.ReadLine();
            if (answer == "yes" || answer == "Yes")
            {
                Console.WriteLine("More information about problem-----> {0}",ex.StackTrace);
            }
        }
        catch(OverflowException ex)
        {
            Console.WriteLine("The number you entered is not a natural number! /r/n  Do you want more detail(yes/no)?");
            string answer = Console.ReadLine();
            if (answer == "yes" || answer == "Yes")
            {
                Console.WriteLine("More information about problem-----> {0}", ex.StackTrace);
            }
        }
        finally
        {
            Console.WriteLine("Good bye :)");
        }
    }
}

