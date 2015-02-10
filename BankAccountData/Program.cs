using System;
using System.Threading; // Activating System.Threading to use Thread.Sleep below!
                /*Problem 11. Bank Account Data
                
                    A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, 
                      IBAN, 3 credit card numbers associated with the account.
                         Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
                */
class BankAccountData
{
    static void Main()
    {
        Console.WriteLine("Wellcome to NetBank!");
        Console.WriteLine(new string('-', 80));

        Console.WriteLine("Sign In:");

        Console.Write("First Name: ");                    //_
        string userFirstName = Console.ReadLine();        // |
        Console.Write("Middle Name: ");                   // |
        string userMiddleName = Console.ReadLine();       // |- Taking the user names
        Console.Write("Last Name: ");                     // |
        string userLastName = Console.ReadLine();         //_|

        Console.Write("Loading: ");
        for (int i = 0; i < 101; i++)    // Loading Animation :)
        {
            Console.SetCursorPosition(10, Console.CursorTop);  // Here I set the cursor position after "Loading: " text. That makes the loading percentage to stay still.
            Console.Write("{0}%", i);
            Thread.Sleep(40);           // Here I use Thread.Sleep to slow down the loop
        }
        Random randomGenerator = new Random();                            //_
        decimal userBalance = randomGenerator.Next(int.MaxValue);         // |
        string iBan = "BG80 BNBG 9661 1020 3456 78";                      // |
        long creditCardOne = 5325983209854333;                            // |- User account information
        long creditCardTwo = 1002982388735555;                            // |
        long creditCardThree = 9923661298560010;                          //_|

        //Printing...
        Console.WriteLine();
        Console.WriteLine(new string('-', 80));
        Console.WriteLine("Hello mr.{0} you have successfully logged in!", userLastName);
        Console.WriteLine("Press \"Enter\" to view your account information!");
        Console.ReadLine();

        Console.WriteLine("\nNetBank - Client Information");
        Console.WriteLine("\nYour balance is: {0} $", userBalance);
        Console.WriteLine("Your IBAN is: {0}", iBan);
        Console.WriteLine("MasterCard number: {0} \nVISA number: {1} \nVISA number: {2}", creditCardOne, creditCardTwo, creditCardThree);
        Console.WriteLine("\nThank you! Have a nice day!");
    }
}

