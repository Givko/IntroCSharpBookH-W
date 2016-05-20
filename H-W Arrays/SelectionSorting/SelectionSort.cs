using System;

class SelectionSort
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int[length];
        int min = int.MaxValue;
        int curMinPos = 0;

        for (int i = 0; i < length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        //Sorting the array with selection sorting method
        for (int i = 0; i < numbers.Length; i++)
        {
            min = int.MaxValue;
            //Finding the current min element in the array
            for (int j = i; j < numbers.Length; j++)
            {
                //Getting the current min value and it's position
                if (min > numbers[j])
                {
                    min = numbers[j];
                    curMinPos = j;
                }
            }

            numbers[curMinPos] = numbers[i];
            numbers[i] = min;

            //for (int z = 0; z < numbers.Length; z++)
            //{
            //Console.Write("The {0} step looks like this: ",z);
            //    Console.Write("{0,1}", numbers[z]);
            //}
            //Console.WriteLine();
        }

        for (int k = 0; k < numbers.Length; k++)
        {
            Console.WriteLine("{0}", numbers[k]);
        }

    }
}