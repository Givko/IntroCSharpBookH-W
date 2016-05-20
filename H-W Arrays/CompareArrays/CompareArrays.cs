using System;

class CompareArrays
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int[length];
        int[] numbers2 = new int[length];
        bool isSame = true;
        
        for (int i = 0; i < length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < length; i++)
        {
            numbers2[i] = int.Parse(Console.ReadLine());
        }

        for (int index = 0; index < length; index++)
        {
            if (numbers[index] != numbers2[index])
            {
                isSame = false;
            }
        }

        Console.WriteLine(isSame?"Equal":"Not equal");
    }
}

