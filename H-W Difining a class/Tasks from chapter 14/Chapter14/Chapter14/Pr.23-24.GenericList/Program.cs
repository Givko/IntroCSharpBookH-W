using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Pr._23_24.GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int numberOfElementsInList = int.Parse(Console.ReadLine());

           ArrayList<double> MyList= new ArrayList<double>(numberOfElementsInList);

            for (int i = 0; i < numberOfElementsInList; i++)
            {
                double currentNumber= double.Parse(Console.ReadLine());
                MyList.Add(currentNumber);
            }

            string newElements = Console.ReadLine();

            string[] elementsToAdd = newElements.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string element in elementsToAdd)
            {
                double elementToDouble = double.Parse(element);

                MyList.Add(elementToDouble);

            }

            string inputIndexes = Console.ReadLine();

            string[] indexesOfElementsToRemove = inputIndexes.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string element in indexesOfElementsToRemove)
            {
                int indexToInt=int.Parse(element);

                MyList.Remove(indexToInt);

            }

            string elementToInsert = Console.ReadLine();

            if (elementToInsert != string.Empty)
            {
                string[] elementAndPosition = elementToInsert.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                MyList.Insert(int.Parse(elementAndPosition[1]), double.Parse(elementAndPosition[0]));
            }

                double elementToSearchInList = double.Parse(Console.ReadLine());
            


            Console.WriteLine(MyList.Count);
            Console.WriteLine(MyList.Capacity);
            
            MyList.ToString();

            if(MyList.Contains(elementToSearchInList)&&MyList.Count!=0)
            {
                Console.WriteLine(MyList.IndexOf(elementToSearchInList));
            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }
    }
}

