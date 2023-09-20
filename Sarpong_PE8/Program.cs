using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarpong_PE8
{

    enum ColorsOfTheRainbow : short
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
    internal class Program
    {
        static void Main(string[] args)
        {

            // 	Write the C# code that creates an array of doubles with a size of 4 and assigns values to the array.
            // The identifier should be precipitation and the values are 0.45, 2.78, 0.04 and 1.22.

            string[] mario = { "hello, goodbye, bonjour" };
            double[] percipitation = { 0.45, 2.78, 0.04, 1.22 };
            for (int cntr = 0; cntr < percipitation.Length; cntr++)
            {
                Console.WriteLine(percipitation[cntr]);
            }

            // Complete the for loop to assign values into the array

            int[] ascendingNumbers = new int[5];
            for (int i = 0; i < ascendingNumbers.Length; i++)
            {
                ascendingNumbers[i] = i + 1;
                Console.WriteLine(ascendingNumbers[i]);
            }

           // string[] blab = new string[5]; 

            //  string[5] = 5th string;

            string sInput = "";
            // prompt user to input a word to be reversed
            Console.Write("Input a word to be reveres in order: ");
            sInput = Console.ReadLine();

            // turn word into character array of separate characters
            char[] letterArray = sInput.ToCharArray();
            Array.Reverse(letterArray);
            Console.WriteLine(letterArray);
            
            


        }
    }
}
