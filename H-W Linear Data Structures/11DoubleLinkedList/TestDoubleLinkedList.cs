using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _11DoubleLinkedList
{
    class TestDoubleLinkedList
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<string> numbers = new DoubleLinkedList<string>();
            List<int> sad = new List<int>();
            Stopwatch watch = new Stopwatch();

            for (int i = 0; i < 100; i++)
            {
                numbers.Add(i.ToString());

            }
            numbers.Insert("5", 1);
            for (int i = 0; i < numbers.Count; i++)
            {
                watch.Start();
                Console.WriteLine(numbers[i]);
                watch.Stop();
                Console.WriteLine(watch.Elapsed);

            }
        }
    }
}
