using System;

class ZeroSubset
{
    static void Main()
    {
        string[] stringOfNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[stringOfNumbers.Length];
        bool notZero = true;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(stringOfNumbers[i]);
        }
        
        if (numbers[0] == 0 && numbers[1] == 0 && numbers[2] == 0 && numbers[3] == 0 && numbers[4] == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
            notZero = false;
        }
        else
        {
            if (numbers[0] + numbers[1] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[0], numbers[1]);
                notZero = false;
            }
            if (numbers[0] + numbers[1] + numbers[2] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[0], numbers[1], numbers[2]);
                notZero = false;
            }
            if (numbers[0] + numbers[1] + numbers[2] + numbers[3] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3}= 0", numbers[0], numbers[1], numbers[2], numbers[3]);
                notZero = false;
            }
            if (numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
                notZero = false;
            }
            if (numbers[0] + numbers[2] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[0], numbers[2]);
                notZero = false;
            }
            if (numbers[0] + numbers[2] + numbers[3] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[0], numbers[2], numbers[3]);
                notZero = false;
            }
            if (numbers[0] + numbers[2] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0}  + {1} + {2} + {3} = 0", numbers[0], numbers[2], numbers[3], numbers[4]);
                notZero = false;
            }
            if (numbers[0] + numbers[3] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[0], numbers[3]);
                notZero = false;
            }
            if (numbers[0] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[0], numbers[3], numbers[4]);
                notZero = false;
            }
            if (numbers[0] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[0], numbers[4]);
                notZero = false;
            }
            if (numbers[1] + numbers[2] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[1], numbers[2]);
                notZero = false;
            }
            if (numbers[1] + numbers[2] + numbers[3] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[1], numbers[2], numbers[3]);
                notZero = false;
            }
            if (numbers[1] + numbers[2] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} + {3}= 0", numbers[1], numbers[2], numbers[3], numbers[4]);
                notZero = false;
            }
            if (numbers[1] + numbers[3] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[1], numbers[3]);
                notZero = false;
            }
            if (numbers[1] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} + {2} = 0", numbers[1], numbers[3], numbers[4]);
                notZero = false;
            }
            if (numbers[1] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[1], numbers[4]);
                notZero = false;
            }
            if (numbers[2] + numbers[3] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[2], numbers[3]);
                notZero = false;
            }
            if (numbers[2] + numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[2], numbers[3], numbers[4]);
                notZero = false;
            }
            if (numbers[2] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[2], numbers[4]);
                notZero = false;
            }
            if (numbers[3] + numbers[4] == 0)
            {
                Console.WriteLine("{0} + {1} = 0", numbers[3], numbers[4]);
                notZero = false;
            }
            if (notZero)
            {
                Console.WriteLine("no zero subset");
            }
        }

    }
}

