using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test_2_Codes
{
    // Nana Sarpong
    // Given the formula z = 4y3 + 2x2 - 8w + 7 write the code for a SortedList<>
    // based on the tuple (double,double,double) representing w, x and y.
    // Use the necessary for() loops to store the values of z (which would also be a double)
    // for the following ranges of w, x and y using the tuple as the index key
    // NO ERRORS 
    internal class Question3
    {
        // create a sorted list based on the Tuple(double, double, double) to perform the equation and get the values
        static void Main(string[] args)
        {
            // sorted list based on tuple with three arguments 
            SortedList<Tuple<double, double, double>, double > Equation = new SortedList<Tuple<double, double, double>, double>();

            //	-2 <= w <= 0 in 0.2 increments
	        //  -1 <= y <= 1 in 0.1 increments
	        //   0 <= x <= 4 in 0.1 increments.


            // declare our variables (w, x, y, z)
            double w = 0;
            double x = 0;
            double y = 0;
            double z = 0;

            // loop through our increments for w
            for (w = -2; w <= 0; w += 0.2){
                w = Math.Round(w, 1); // round to one decimal place

                 // loop through our increments for x
                for (x = -1; x <= 1; x += 0.1)
                {
                    x = Math.Round(x, 1); // round to one decimal place


                    // loop through our increments for y
                    for (y = 0; y <= 4; y+= 0.1)
                    {
                        y = Math.Round(y, 1); // round to one decimal place

                        // z = 4y3 + 2x2 - 8w + 7 
                        z = 4 * Math.Pow(y, 3) + 2 * Math.Pow(x, 2) - 8 * (w) + 7;
                        z = Math.Round(z, 3);

                        // store the values to our SortedList based on our tuple
                        Equation.Add(new Tuple<double,double,double>(w, x, y), z);
                    }
                    
                }
                
            }

            // to test that the values appear
            // look at each entry pair (key, value in our Sorted List based on a tuple)
            foreach (var entry in Equation)
            {
                var tuple = entry.Key; // set get the key of ecntry
                 z = entry.Value; // set z which is out final number as the value
                // output the values for w, x, y, and z
                Console.WriteLine($"(w:{tuple.Item1:F1}, x:{tuple.Item2:F1}, y:{tuple.Item3:F1}) => z:{z:F3}");
            } 





        }
    }
}
