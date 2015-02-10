using System;
                /*Problem 9. Exchange Variable Values
                
                    Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
                    Print the variable values before and after the exchange.
                */
class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c = a; //I use another variable to asign the "a" value in it, and use it again later.

        Console.WriteLine("a = {0} \nb = {1}", a, b);

        a = b;
        b = c;

        Console.WriteLine("Now we exchange their values: \na = {0} \nb = {1}", a, b);
    }
}

