using System;
                /*Problem 6. Strings and Objects
                
                    Declare two string variables and assign them with Hello and World.
                    Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
                    Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
                */
class StringsAndObjects
{
    static void Main()
    {
        string hello = "Hello"; // To add a space we can enter it here, but I thing it's kind of bad practise doing that. Example: "Hello "
        string world = "World"; // Or here: " World";

        object helloWorld = hello + " " + world;

        string convertedObject = Convert.ToString(helloWorld);

        Console.WriteLine("We have two string values: {0} and {1}. \nNow we have those two together: {2}! \nBye!",hello, world, convertedObject);
    }
}

