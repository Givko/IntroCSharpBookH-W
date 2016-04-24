using System;

class FindingSumInArray
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 6, 4, 8, 3 };
        Console.Write("Enter Sum = ");
        int s = int.Parse(Console.ReadLine());
        int sum = 0;
        int startIndex = 0;
        int counter = 0;

        //Checking if here is a sequence which sum is equale to the sum given by the user
        for (int i = 0; i < numbers.Length; i++)
        {
            sum = 0;
            counter = 0;
            for (int j = i; j < numbers.Length; j++)
            {
                //Calculating sum and count how many time did the loop iterate
                sum += numbers[j];
                counter++;
               
                //Checking if the current sum is equal to the on given by the user. If so we exit the inner loop
                if (sum == s)
                {

                    //Getting the satrt positio of the sequence
                    startIndex = i;
                    break;
                }
            }
            //If we have found a sum equal to the one given by the user we exit the outer loop
            if (sum==s)
            {
                break;
            }
        }
        
        //If there is such a sequence print it
        if (sum == s)
        {
            Console.Write("The sequence which sum={0} is: ",s);
            
            for (int i = 0; i < counter; i++)
            {
                Console.Write(",{0} ",numbers[startIndex]);
                startIndex++;
            }
            
            Console.WriteLine();

        }
        //Else print there is no such sequence
        else
        {
            Console.WriteLine("There is no sequence in the array which sum is {0}", s);
        }

    }
}

