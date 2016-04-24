using System;

class RandomizeNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program will print on the console randomly the numbers from 1 to n.");
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int[] numbersRandomize = new int[numbers.Length];
        bool isNumber = true;
        bool isEmpty = true;
        int number;
        Random num = new Random();

        //Inserting numbers 1 to n in the array
        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;

        }

        //Puts the numbers from numbers[] to numbersRandomize[] in a random pattern
        while (isEmpty)
        {
            isEmpty = false;

            for (int i = 0; i < numbers.Length; i++)
            {

                number = numbers[num.Next(0, numbers.Length)];
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbersRandomize[j] == number)
                    {
                        isNumber = false;
                    }
                }
                if (isNumber)
                {
                    numbersRandomize[i] = number;
                }
                isNumber = true;
            }

            //Checks if any of the elemnts in the array is a 0
            for (int z = 0; z < numbersRandomize.Length; z++)
            {
                if (numbersRandomize[z] == 0)
                {
                    isEmpty = true;
                }
            }
        }

        Console.Clear();

        //Prints the numbers 1 to N in a random fashion
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0, 2}", numbersRandomize[i]);
        }
        Console.WriteLine();
    }

}


//Console.WriteLine("Please enter a integer number:");
//int num = int.Parse(Console.ReadLine());
//int[] array = new int[num];
//for (int index = 0; index < num; index++)
//{
//    array[index] = index + 1;
//}

//Random random = new Random();
//foreach (int index in array)
//{
//    int randNum = random.Next(0, num);
//    int temp = array[randNum];
//    array[randNum] = array[0];
//    array[0] = temp;
//}
//Console.WriteLine(String.Join(" ", array));
