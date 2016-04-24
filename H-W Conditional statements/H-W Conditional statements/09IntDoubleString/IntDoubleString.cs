using System;

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose what you want to enter: 1--> int, 2--> double or 3 --> string: ");
        byte choice = byte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Please enter your integer number: ");
                int num1 = int.Parse(Console.ReadLine());
                num1 += 1;
                Console.WriteLine(num1);
                break;
            case 2:
                Console.Write("Please enter your real number: ");
                double num2 = double.Parse(Console.ReadLine());
                num2 += 1;
                Console.WriteLine(num2);
                break;
            case 3:
                Console.Write("Please enter your string: ");
                string str = Console.ReadLine();
                Console.WriteLine(str + "*");
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;

        }
    }
}

