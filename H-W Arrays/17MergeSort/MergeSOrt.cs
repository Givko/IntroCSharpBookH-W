using System;
using System.Linq;

class MergeSort
{
    static int[] numbers;
    static int[] helperArray;

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        numbers = new int[n];
        helperArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        MergeSorting(0, numbers.Length - 1);

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

    }

    private static void MergeSorting(int left, int right)
    {
        int i = 0;
        int j = 0;
        int k = 0;
        int mid = 0;

        if (right <= left)
        {
            return;
        }

        mid = (left + right) / 2;
        MergeSorting(left, mid);
        MergeSorting(mid + 1, right);

        for (i = mid + 1; i > left; i--)
        {
            helperArray[i - 1] = numbers[i - 1];
        }

        for (j = mid; j < right; j++)
        {
            helperArray[right + mid - j] = numbers[j + 1];
        }

        for (k = left; k <= right; k++)
        {
            numbers[k] = (helperArray[i] < helperArray[j]) ? helperArray[i++] : helperArray[j--];
        }
    }
}