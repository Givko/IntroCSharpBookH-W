using System;

class AdvertisingMessage
{
    static void Main()
    {
        string[] laudatoryPhrases = new string[]
        {
            "The product is excellent.",
            "This is a great product.",
            "I use this product constantly.",
            "This is the best product from this category."
        };

        string[] laudatoryStories = new string[] 
        {
            "Now I feel better.",
            "I managed to change.",
            "It made some miracle.",
            "I can’t believe it, but now I am feeling great.",
            "You should try it, too. I am very satisfied." 
        };

        string[] firstNames = new string[] 
        {
            "Dayan",
            "Stella",
            "Hellen",
            "Kate" 
        };

        string[] lastName = new string[] 
        { 
            "Johnson",
            "Peterson",
            "Charls" 
        };

        string[] cities = new string[] 
        {
            "London",
            "Paris",
            "Berlin", 
            "New York",
            "Madrid"
        };

        Random rand = new Random();

        Console.WriteLine("{0} {1} --{2} {3},{4}",
            laudatoryPhrases[rand.Next(0, 4)],
            laudatoryStories[rand.Next(0, 5)],
            firstNames[rand.Next(0, 4)],
            lastName[rand.Next(0, 3)],
            cities[rand.Next(0, 5)]);
    }
}