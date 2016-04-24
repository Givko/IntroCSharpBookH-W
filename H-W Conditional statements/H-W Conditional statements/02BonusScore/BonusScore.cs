using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter score: ");
        byte score = byte.Parse(Console.ReadLine());

        switch (score)
        {
            case 1:
            case 2:
            case 3:
                Console.Clear();
                Console.Write("Your total score is:{0} \n",score*10);
                break;
            case 4:
            case 5:
            case 6:
                Console.Clear();
                Console.Write("Your total score is:{0} \n", score * 100);
                break;
            case 7:
            case 8:
            case 9:
                Console.Clear();
                Console.Write("Your total score is:{0} \n", score * 1000);
                break;
            default:
                Console.Clear();
                Console.WriteLine("Invalid score!");
                break;
        }
    }
}

