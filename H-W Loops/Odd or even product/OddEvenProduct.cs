using System;

class OddEvenProduct
{
    static void Main(string[] args)
    {

        string[] num = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[num.Length];
        int evenProduct = 1;
        int oddProduct = 1;

        //parses the elements from string array num[] to integer numbers[]
        for (int i = 0; i < num.Length; i++)
        {
            numbers[i] = int.Parse(num[i]);
        }
        //checks which of the elements in integer array numbers[] are even and which odd
        for (int i = 1; i <= numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenProduct *= numbers[i - 1];
            }
            else
            {
                oddProduct *= numbers[i - 1];
            }
        }

        //checks if the products are equal or not
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("equal product {0}", evenProduct);

        }
        else
        {
            Console.WriteLine("No. Even product = {0}, odd product = {1}", evenProduct, oddProduct);
        }

    }
}

