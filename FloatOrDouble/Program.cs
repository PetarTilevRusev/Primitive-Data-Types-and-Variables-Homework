using System;
                /* Problem 2. Float or Double?
                    Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
                    Write a program to assign the numbers in variables and print them to ensure no precision is lost.*/
class FloatOrDouble
  {
      static void Main()
      {
          double firstNumber = 34.56789023d;
          float secondNumber = 12.345f;
          double thirdNumber = 8923.1234857d;
          float forthNumber = 3456.091f;

          Console.WriteLine("Press \"Enter\" to run the program!");
          Console.ReadLine();

          Console.WriteLine("Double: {0} and {1}", firstNumber, thirdNumber);
          Console.WriteLine("Float: {0} and {1}", secondNumber, forthNumber);
      }
  }

