using System;
                /* Problem 1. Declare Variables
                    Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following  
                    values: 52130, -115, 4825932, 97, -10000.
                    Choose a large enough type for each number to ensure it will fit in it. Try to compile the code. */
class DeclareVariables
{
    static void Main()
    {
        Console.WriteLine("Press \"Enter\" to run the program!");
        Console.ReadLine();

        ushort firstNumber = 52130;
        sbyte secondNumber = -115;
        uint thirdNumber = 4825932;
        byte forthNumber = 97;
        short fifthNumber = -10000;

        Console.WriteLine("Ushort number: {0} \nSbyte number: {1} \nUint number: {2} \nByte number: {3} \nShort number: {4}", firstNumber, secondNumber, thirdNumber, forthNumber, fifthNumber);

    }
}

