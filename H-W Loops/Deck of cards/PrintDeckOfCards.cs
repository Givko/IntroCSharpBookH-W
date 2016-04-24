using System;
using System.Text;

class PrintDeckOfCards
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        char[] suits = new char[] { '♠', '♥', '♦', '♣' };

        for (int cards = 2; cards <= 14; cards++)
        {
            for (int i = 0; i <= 3; i++)
            {

                switch (cards)
                {
                    case 2:
                        Console.Write("2{0}", suits[i]);
                        break;
                    case 3:
                        Console.Write("3{0}", suits[i]);
                        break;
                    case 4:
                        Console.Write("4{0}", suits[i]);
                        break;
                    case 5:
                        Console.Write("5{0}", suits[i]);
                        break;
                    case 6:
                        Console.Write("6{0}", suits[i]);
                        break;
                    case 7:
                        Console.Write("7{0}", suits[i]);
                        break;
                    case 8:
                        Console.Write("8{0}", suits[i]);
                        break;
                    case 9:
                        Console.Write("9{0}", suits[i]);
                        break;
                    case 10:
                        Console.Write("10{0}", suits[i]);
                        break;
                    case 11:
                        Console.Write("J{0}", suits[i]);
                        break;
                    case 12:
                        Console.Write("Q{0}", suits[i]);
                        break;
                    case 13:
                        Console.Write("K{0}", suits[i]);
                        break;
                    case 14:
                        Console.Write("A{0}", suits[i]);
                        break;
                }

            }

            Console.WriteLine();

        }
    }
}
