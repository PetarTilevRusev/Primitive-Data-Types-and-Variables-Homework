using System;
class PrintASCIITable
{
    static void Main()
    {
        //Here are the cols
        Console.Write("Decimal".PadRight(10));
        Console.Write("ASCII".PadRight(10));
        Console.Write("Hex".PadRight(10));
        Console.WriteLine();

        int min = 0;
        int max = 128;
        for (int i = min; i < max; i++)
        {
            //Here I make ascii character.
            char c = (char)i;

            //Creating string value to display the results
            string display = string.Empty;
            if (char.IsWhiteSpace(c)) 
            {
                display = c.ToString();
                switch (c)      //Here are the switch options, couse some elements will not be displayed currectly. For example: \n = new row \r = start from the begining " " = space and so on.
                {
                    case '\t':
                        display = "\\t";
                        break;
                    case ' ':
                        display = "space";
                        break;
                    case '\n':
                        display = "\\n";
                        break;
                    case '\r':
                        display = "\\r";
                        break;
                    case '\v':
                        display = "\\v";
                        break;
                    case '\f':
                        display = "\\f";
                        break;
                }
            }
            else if (char.IsControl(c)) //If "c" is "control" charecter, display control.
            {
                display = "control"; 
            }
            else
            {
                display = c.ToString(); //Converting "c" to string to be displaied
            }
            // Write table row.
            Console.Write(i.ToString().PadRight(10));
            Console.Write(display.PadRight(10));
            Console.Write(i.ToString("X2"));
            Console.WriteLine();
        }
    }
}

