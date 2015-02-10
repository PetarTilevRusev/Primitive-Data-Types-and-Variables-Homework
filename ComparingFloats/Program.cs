using System;
                /*Problem 13.* Comparing Floats
                
                    Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
                
                    Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
                
                        Examples:
                        Number a 	Number b 	Equal (with precision eps=0.000001) 	Explanation
                        5.3         6.01      	false   The difference of 0.71 is too big (> eps)
                        5.00000001 	5.00000003 	true 	The difference 0.00000002 < eps
                        5.00000005 	5.00000001 	true 	The difference 0.00000004 < eps
                        -0.0000007 	0.00000007 	true 	The difference 0.00000077 < eps
                        -4.999999 	-4.999998 	false 	Border case. The difference 0.000001 == eps. We consider the numbers are different.
                        4.999999 	4.999998 	false 	Border case. The difference 0.000001 == eps. We consider the numbers are different.*/
class ComparingFloats
{
    static void Main()
    {
        //Creating arrays to hold the needed values
        decimal eps = 0.000001m;                 //I use decimal for better precision.
        decimal[] a = { 5.3M, 5.00000001M, 5.00000005M, -0.0000007M, -4.999999M, 4.999999M}; 
        decimal[] b = { 6.01M, 5.00000003M, 5.00000001M, -0.0000007M, -4.999998M, 4.999998M};
        //This array will hold the results
        decimal[] resultArray = new decimal[6]; 

        //Some text to describe what is going on
        Console.WriteLine("Our task is to compare some numbers with precision of 0.000001"); 
        Console.WriteLine(new string('-', 80));

        //"for" loop for calculating all elements from array "a" with all elements from array "b"
        for (int i = 0; i < a.Length; i++)
        {
            //if and else for escaping the negative values of resultArray outputs. The formula (a[i] - b[i]) * (-1) doesn't work.
            if (a[i] >= b[i]) 
            {
                resultArray[i] = (a[i] - b[i]);
                bool isBigger = resultArray[i] < eps;
                Console.WriteLine("Number a = {0} Number b = {1}. Equal: {3} \nDifference between a and b: {2}.", a[i], b[i], resultArray[i], isBigger);
                Console.WriteLine();
            }
            else
            {
                resultArray[i] = (b[i] - a[i]);
                bool isBigger = resultArray[i] < eps;
                Console.WriteLine("Number a = {0} Number b = {1}. Equal: {3} \nDifference between a and b: {2}.", a[i], b[i], resultArray[i], isBigger);
                Console.WriteLine();
            }
            
        }
        
    }
}

