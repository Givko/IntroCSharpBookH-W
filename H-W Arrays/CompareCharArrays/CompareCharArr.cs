using System;

class CompareCharArr
{
    static void Main(string[] args)
    {
        string array1 = Console.ReadLine();
        string array2 = Console.ReadLine();

        if (array1.CompareTo(array2) == 0)
        {
            Console.WriteLine("=");
        }
        else if (array1.CompareTo(array2) == -1)
        {
            Console.WriteLine("<");
        }
        else
        {
            Console.WriteLine(">");
        }
    }
}
