using System;

namespace SquashTheBugs
{
    // Class Program
    // Author: Nana Sarpong
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter

            // this is a syntax error - semicolon is to be expected at line of code
            // int i = 0
            int i = 0;

            // declare string to hold all numbers
            string allNumbers = null;

            // loop through the numbers 1 through 10

            // logical error - the array length is only 9
            //  for (i = 1; i < 10; ++i)
            for (i = 1; i <= 10; ++i)
            {



                // logical error - won't allow variable to be in scope outside of for loop
                //  string allNumbers = null;

                // output explanation of calculation

                // this is a logical error - operand is trying to add an integer to a string
                // Console.Write(i + "/" + i - 1 + " = ");

                Console.WriteLine(i + "/" + (i - 1) + " =");

                // output the calculation based on the numbers

                // Run-time error - program attempted to divide 1 by 0
                //  Console.WriteLine(i / (i - 1));

                try
                {
                    Console.WriteLine(i / (i - 1));
                }
                catch
                {
                    Console.WriteLine("No Way, Jose!");
                }





                // concatenate each number to allNumbers





                allNumbers += i + " ";

                // increment the counter


                // logical error - skips over the even numbers
                //  i = i + 1;
                i = (i + 1) - 1;






            }


            // output all numbers which have been processed

            // this is a runtime error - the variable is not in scope of the brackets
            // this is also a syntax error - you cant put string and its together without a comma or "+" sign
            //  Console.WriteLine("These numbers have been processed: " allNumbers);

            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}
