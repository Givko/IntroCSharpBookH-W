using System;

namespace string_and_objects
{
    class stringandobject
    {
        static void Main()
        {
            string greeting = "Hello";
            string world = "World!";
            object greetingworld= greeting + " " + world;
            string object1 = (string)greetingworld;
            Console.WriteLine(object1);
        }
    }
}
