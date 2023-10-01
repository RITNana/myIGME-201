using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test_1_Scratchwork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input1;
            string input2;
            double val2;
            double val1;
            double answer;
            Console.WriteLine("add two doubles");
            input1 = Console.ReadLine();
            input2 = Console.ReadLine();
            val1 = double.Parse(input1);
            val2 = double.Parse(input2);
            answer = val1 + val2;
            answer = Math.Round(answer, 2);
            Console.WriteLine(answer);
           


           /* double[][] dArray = new int[2][];
            dArray[1] = new double[2];
            dArray[2] = new double[1]

            dArray[0][0] = 15;
            dArray[1][2] = 5.67; */



































            // Question 8
            // Given the formula z = 4y3 + 2x2 - 8x + 7 implement a multidimensional array, the necessary for () loops and the code to store the values of z for the following ranges of x and y into the array:
            //	-1 <= y <= 1 in 0.1 increments // 21 values
            //0 <= x <= 4 in 0.1 increments. // 39 values

            double x = 0;
            double y = 0; // hold values for y variable
            double z = 0; // hold final result for z value

            int nX = 0; // x counter
            int nY = 0; // y counter


            double[,,] zFunc = new double[21, 39, 3];
            for (x = -1; x <= 1; x += 0.1, nX++) // x goes from -1 to 1 incrementing by .1, with entire array incrementing at each index
            {
                x = Math.Round(x, 1); // rounded to one decimla place

                // start with the 0'th "y" bucket for this value of x
                nY = 0;

                for (y = 0; y <= 4; y += 0.1, ++nY) // x goes from 1 to 5 incrementing by .1, with entire array incrementing at each index
                {
                    y = Math.Round(y, 1); // rounded to one decimal place 

                    z = 4 * Math.Pow(y, 3) +  2 * Math.Pow(x, 2) - 8 * (x) + 7; // math calculation to find z

                    z = Math.Round(z, 3); // base doff sig figs, round 2 to 3 decimal places

                    zFunc[nX, nY, 0] = x; // store the values
                    zFunc[nX, nY, 1] = y; // store the values
                    zFunc[nX, nY, 2] = z; // store the values

                    // correction; incremenent values (y array index)
                    ++y;
                }
                // correction: increment values;
                ++nX;

            }
        }
    }
}
