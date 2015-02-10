using System;
                /* Problem 3. Variable in Hexadecimal Format
                    Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
                    Use Windows Calculator to find its hexadecimal representation.
                    Print the variable and ensure that the result is 254. */
class VariableInHexadecimalFormat
{
    static void Main()
    {
        string hex = "0xFE";
        int number = 0xFE;

        Console.WriteLine("The value in hexadecimal format {0} is: {1}", hex, number);
    }
}

