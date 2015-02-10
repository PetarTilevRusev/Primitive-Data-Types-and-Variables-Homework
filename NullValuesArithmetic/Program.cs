using System;
                /*Problem 12. Null Values Arithmetic
                
                    Create a program that assigns null values to an integer and to a double variable.
                    Try to print these variables at the console.
                    Try to add some number or the null literal to these variables and print the result.
                */
class NullValuesArithmetic
{
    static void Main()
    {
        //Describing the values
        int? firstNull = null;                  
        double? secondNull = null;              
        int firstNumber = 42234;                
        double secondNumber = 322.156543d;      

        //Printing
        Console.WriteLine("Here we have two Null numbers!");
        Console.WriteLine("Integer number = {0} \nDouble number = {1}", Convert.ToInt32(firstNull), Convert.ToDouble(secondNull));  //To get the integer and double numbers out I need to convert them first.

        //Making calculations and printing
        firstNull = Convert.ToInt32(firstNull) + firstNumber;           //To make the calculation I need to convert them again
        secondNull = Convert.ToDouble(secondNull) + secondNumber;
        Console.WriteLine("\nHere I convert the int and double values!");
        Console.WriteLine("Integer number = {0} \nDouble number = {1}", firstNull, secondNull);

        Console.WriteLine("\nHere I multiply the int and double values!");
        firstNull = firstNull * firstNumber;            //After I convert them once and now they have values, the multiply operator works here.
        secondNull = secondNull * secondNumber;
        Console.WriteLine("Integer number = {0} \nDouble number = {1}", firstNull, secondNull);

    }
}

