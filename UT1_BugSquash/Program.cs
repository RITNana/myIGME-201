

using System;

namespace UT1_BugSquash
{

    // Nana Sarpong
    // Question 14 - Unit Test 1
    // Errors: didn't finish
    class Program
    {
        // Calculate x^y for y > 0 using a recursive function
        static void Main(string[] args)
        {
            string sNumber = null;
            int nX;
            //   int nY // compile-time error - needs a semicolon 
            int nY;
            int nAnswer;

            // Console.WriteLine(This program calculates x ^ y.); // compile time error - needs quotation marks
            Console.WriteLine("Thus program calculates x ^ y. ");

            do
            {
                Console.Write("Enter a whole number for x: ");
                Console.ReadLine();
            } //while (!int.TryParse(sNumber, out nX));
            while (!int.TryParse(sNumber, out nX));// compile time error - sNumber has not been declared

            do
            {
                Console.Write("Enter a positive whole number for y: ");
                sNumber = Console.ReadLine();
            }// while (int.TryParse(sNumber, out nX)); // logical time error - won't run the code in the "do" part of the do-while loop
            while (!int.TryParse(sNumber, out nX));

            // compute the exponent of the number using a recursive function
            //    nAnswer = Power(nX, nY); // syntax error and compile time - needs to have Math added to
           
            Console.WriteLine("{nX}^{nY} = {nAnswer}");
        }


        int Power(int nBase, int nExponent)
        {
            int returnVal = 0;
            int nextVal = 0;

            // the base case for exponents is 0 (x^0 = 1)
            if (nExponent == 0)
            {
                // return the base case and do not recurse
                returnVal = 0;
            }
            else
            {
                // compute the subsequent values using nExponent-1 to eventually reach the base case
                nextVal = Power(nBase, nExponent + 1);

                // multiply the base with all subsequent values
                returnVal = nBase * nextVal;
            }

            returnVal;
        }
    }
}
