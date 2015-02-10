using System;
                /*Problem 10. Employee Data
                
                  A marketing company wants to keep record of its employees. Each record would have the following characteristics:
                
                    First name
                    Last name
                    Age (0...100)
                    Gender (m or f)
                    Personal ID number (e.g. 8306112507)
                    Unique employee number (27560000…27569999)
                
                    Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
                 */
class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("Hello there! \nPlease follow the instructions and fill the information that we need!");
        Console.WriteLine(new string('-', 80));                  //A row with "----" just to make the "user interface" (console :D:D:D) more prity
        
        Console.Write("Please enter your first name: ");
        string employeeFirstName = Console.ReadLine();
        
        Console.Write("Please enter your last name: ");
        string employeeLastName = Console.ReadLine();
        
        Console.Write("Please enter your age: ");
        string employeeAge = Console.ReadLine();
        
        Console.Write("Please enter your gender: ");
        string employeeGender = Console.ReadLine();
        
        Random randomGenerator = new Random();                           //I create a random variable to generate the numbers that I need
        int personalID = randomGenerator.Next(int.MaxValue);                 //Here I use the random variable. In "()" is the range, personalID = from 0 to int.MaxValue
        int uniqueEmployeeNumber = randomGenerator.Next(27560000, 27569999);     // Here the range is set by the task, from 27560000 to 27569999.
        
        System.Console.Clear();             //Here I clear all the shit that was made :D

        if (employeeGender == "Male" || employeeGender == "male" ||
            employeeGender == "M" || employeeGender == "m")             //Here I check the employee gender.
        {
            Console.WriteLine("Hello mr. {0}! \nWelcome to PeterCorporation!", employeeLastName);                //Some bullshit 
            Console.WriteLine(new string('-', 80));                                                              //User interface rocks... 
            Console.WriteLine("We are glad to have someone so talanted and handsome like you in our team!");     //Some bullshit 
        }
        else if (employeeGender == "Female" || employeeGender == "female" ||
            employeeGender == "F" || employeeGender == "f")            //Gender check again
        {
            Console.WriteLine("Hello ms. {0}! \nWelcome to PeterCorporation!", employeeLastName);                //Some bullshit again
            Console.WriteLine(new string('-', 80));                                                              //User interface rocks... again!
            Console.WriteLine("We are glad to have someone so talanted, beautiful and sexy in our team!");       //Some bullshit again
        }

        Console.WriteLine("Personal ID: {0} \nEmployee number: {1}", personalID, uniqueEmployeeNumber);          //Printing the personalID and uniqueEmployeeNumber

        //Did you get fun testing it?
        //Couse I had twise much fun making it :)

    }

}

