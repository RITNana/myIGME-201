using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarpong_PE8
{
    
    enum ColorsOfTheRainbow : short // testing enum with byte data type
    {
        red = 26,
        orange = 34,
        yellow = 45,
        green = 23,
        blue = 22,
        indigo = 44,
        violet = 66,
        black = 56,
        white = 78
    }

    // Nana Sarpong
    // PE8 - Coded Asnwers & Testing
    // 9/20/23
    internal class Program
    {
        static void Main(string[] args)
        {

            // 	Write the C# code that creates an array of doubles with a size of 4 and assigns values to the array.
            // The identifier should be precipitation and the values are 0.45, 2.78, 0.04 and 1.22.

            
            double[] percipitation = { 0.45, 2.78, 0.04, 1.22 }; // create a double array with four values based on the length of the array
            for (int cntr = 0; cntr < percipitation.Length; cntr++)
            {
                Console.WriteLine(percipitation[cntr]); // print the double array
            }

            // Complete the for loop to assign values into the array

            int[] ascendingNumbers = new int[5]; // declare an array with 5 elements
            for (int i = 0; i < ascendingNumbers.Length; i++) // iterate through the ascendingNumbers array
            {
                ascendingNumbers[i] = i + 1; // outsputs values 1,2,3,4,5
                Console.WriteLine(ascendingNumbers[i]);
            }

            // string[] blab = new string[5]; 

            //  string[5] = 5th string;

            // Question 8
            string startString = Console.ReadLine();
            string endString = "";
            endString = startString.Replace("No ", "Yes ").Replace("No, ", "Yes, ").Replace("No.", "Yes.").Replace("No. ", "Yes. ");
            Console.WriteLine(endString);

            // Question 7
            string sInput = "";
            // prompt user to input a word to be reversed
            Console.Write("Input a word to be reversed in order: ");
            sInput = Console.ReadLine();
             
            // turn word into character array of separate characters
            char[] letterArray = sInput.ToCharArray();
            Array.Reverse(letterArray);
            Console.WriteLine(letterArray);

            // Quesrion 9
            string sentence = Console.ReadLine(); // user's input is read by program
            string[] aString = sentence.Split(' '); // create a string array based on user input and split the sentence into words
            string addQuotes = ""; // declare our quotes string
            foreach(string thisWord in aString) // for each word element in our aSting array
            {
                addQuotes += "\" " + thisWord + "\" "; // add the word element plus a double quote around each word
            }

            Console.WriteLine(addQuotes); // output the results

















        }
    }
}
