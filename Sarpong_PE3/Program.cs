using System;


namespace Sarpong_PE3
{
    
   

    internal class Program
    {
        // Nana Sarpong
        // Write a console application that obtains four int values from the user and displays the product
        // No known errors
        static void Main(string[] args)
        {



            string sValue1 = null; // value number one input
            string sValue2 = null; // value number two input
            string sValue3 = null; // value number three input
            string sValue4 = null; // value number four input
            

            int? nValues1 = null; // value number 1 (to convert)
            int? nValues2 = null; // value number 2 (to convert)
            int? nValues3 = null; // value number 3 (to convert)
            int? nValues4 = null; // value number 4 (to convert)
            

            // Prompt user to input numbers 
            Console.Write("Enter first number: ");
            sValue1 = Console.ReadLine(); // read the line for user input on number 1

            Console.Write("Enter second number: ");
            sValue2 = Console.ReadLine(); // read the line for user input on number 2

            Console.Write("Enter third number: ");
            sValue3 = Console.ReadLine(); // read the line for user input on number 3

            Console.Write("Enter fourth number: ");
            sValue4 = Console.ReadLine(); // read the line for user input on number 4

            // while nValues1 hasn't been set to a number
            while (nValues1 == null)
            {
                try // try to convert from string to integer (without try, our code will crash)
                {
                    nValues1 = Convert.ToInt32(sValue1); // the int variable nValues1 will hold the new converted integer for number 1
                    nValues2 = Convert.ToInt32(sValue2); // the int variable nValues2 will hold the new converted integer for number 2
                    nValues3 = Convert.ToInt32(sValue3); // the int variable nValues3 will hold the new converted integer for number 3
                    nValues4 = Convert.ToInt32(sValue4); // the int variable nValues4 will hold the new converted integer for number 5
                    int? result = (nValues1 * nValues2 * nValues3 * nValues4); // use the multiplcation operation to get the product for our numbers
                    Console.WriteLine("The answer is: " + result);

                }
                catch // what will happen if the try block doesn't work
                {
                    Console.Write("Please Try Again");
                }
                
            }













        }
    }
}
