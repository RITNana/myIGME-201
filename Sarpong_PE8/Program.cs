using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography;
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
                ascendingNumbers[i] = i + 1; // index + 1 equals element featured from index value
                Console.WriteLine(ascendingNumbers[i]);  // outputs values 1,2,3,4,5
            }
         



            // Question 5
            // calculate z = 3y^2 + 2x - 1
            // 	-1 <= x <= 1 in 0.1 increments //20 increments
            //	1 <= y <= 4 in 0.1 increments // 30 increments

            double x = 0; // hold values for x variable
            double y = 0; // hold values for y variable
            double z = 0; // hold final result for z value

            int nX = 0; // x counter
            int nY = 0; // y counter

            //        20 values of x
            //        30 values of y for each value of x
            //        3 values for each data point: the x, y and z

            double[,,] zFunc = new double[20, 30, 3];

            for (x = -1; x <= 1; x += 0.1, nX++) // x goes from -1 to 1 incrementing by .1, with entire array incrementing at each index
            {
                x = Math.Round(x, 1); // rounded to one decimla place

                // start with the 0'th "y" bucket for this value of x
                nY = 0;

                for (y = 1; y <= 5; y += 0.1, ++nY) // x goes from 1 to 5 incrementing by .1, with entire array incrementing at each index
                {
                    y = Math.Round(y, 1); // rounded to one decimal place 

                    z = 3 * Math.Pow(y, 2) + (2 * x) - 6; // math calculation to find z

                    z = Math.Round(z, 3); // base doff sig figs, round 2 to 3 decimal places

                 //   zFunc[nX, nY, 0] = x; // store the values
                  //  zFunc[nX, nY, 1] = y; // store the values
                 //  zFunc[nX, nY, 2] = z; // store the values
                }
            }

            Console.WriteLine("z = " + z); // calculated z result






            // string[] blab = new string[5]; 

            //  string[5] = 5th string;

            // Question 8
            Console.WriteLine("Question 8: ");
            string startString = Console.ReadLine(); // write a sentence with No that will be switched to yes
            string endString = "";

            // different types of "no" spellings accomadated with their yes counterpart
            endString = startString.Replace("No ", "Yes ").Replace("No, ", "Yes, ").Replace("No.", "Yes.").Replace("No. ", "Yes. ");
            Console.WriteLine(endString); // output the result

            // Question 7
            Console.WriteLine("Question 7");
            string sInput = "";
            // prompt user to input a word to be reversed
            Console.Write("Input a word to be reversed in order: ");
            sInput = Console.ReadLine();
             
            // turn word into character array of separate characters
            char[] letterArray = sInput.ToCharArray(); // separate input into an array of letters
            Array.Reverse(letterArray); // reverse the order of the letter array
            Console.WriteLine(letterArray); // output the results

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
