using System;
                /*Problem 7. Quotes in Strings
                
                    Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
                    Do the above in two different ways - with and without using quoted strings.
                    Print the variables to ensure that their value was correctly defined.
                */
class QuotesInStrings
{
    static void Main()
    {
        string solution = "The use of quotations causes difficulties.";
        string solutionTwo = "The \"use\" of quotations causes difficulties.";

        Console.WriteLine("Here we escape quotes: {0}", solution);
        Console.WriteLine("Here we use quotes: {0}", solutionTwo);
    }
}

