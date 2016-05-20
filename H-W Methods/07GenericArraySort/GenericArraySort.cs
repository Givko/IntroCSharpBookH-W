using System;
using System.Collections.Generic;
using System.Linq;

class GenericArraySort
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 4, 5, 7, 3, 5, 3, 2 };
        string[] strings = { "zaz", "bab", "bbb", "zfz", "jivko", "jivko milev", "milko", "pesho" };
        DateTime[] dates = {
                               new DateTime(2002,3,2),new DateTime(2015,5,6),new DateTime(2014,1,1)
                           };

        SortArray(numbers);
        SortArray(strings);
        SortArray(dates);
        Console.WriteLine("{0}", string.Join(", ", numbers));
        Console.WriteLine("{0}", string.Join(", ", strings));
        Console.WriteLine("{0}", string.Join("; ", dates));
    }
    private static void SortArray<T>(T[] elements) where T : IComparable
    {
        if (elements.Length==0)
        {
            return;
        }
        T curMin;
        int curMinIndex = 0;
        for (int i = 0; i < elements.Length; i++)
        {
            curMinIndex = i;
            curMin = elements[i];
            
            for (int j = i; j < elements.Length; j++)
            {
                if (elements[j].CompareTo(curMin)<0)
                {
                    curMin = elements[j];
                    curMinIndex = j;
                }
             
            }

            elements[curMinIndex] = elements[i];
            elements[i] = curMin;
        }
    }
}

