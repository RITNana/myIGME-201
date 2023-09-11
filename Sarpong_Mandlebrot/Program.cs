using System;
using System.Runtime.Remoting.Metadata;

namespace Mandelbrot
{
    /// <summary>
    /// This class generates Mandelbrot sets in the console window!
    /// </summary>


    class Class1
    {
        /// <summary>
        /// This is the Main() method for Class1 -
        /// this is where we call the Mandelbrot generator!
        /// </summary>
        /// <param name="args">
        /// The args parameter is used to read in
        /// arguments passed from the console window
        /// </param>

        [STAThread]
        // Nana Sarpong
        // Manderlbrot Program
        /* Modify the Mandelbrot set application to request image limits from the user
         and display the chosen section of the image */

        //Errors: 
        // Modified Code doesn't work corrcetly, causes the program to crash
        // Wasn't able to implement user input to allow a broad selection of ranges for realCoord and imagCoord
        // Modified code is all commented out except for the variables I created in attempt to modify the code
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            // initialize starting and ending values of imageCoord (y-axis)

            double? startImagCoord = null; //(limit value is 1.2)
            double? endImagCoord = null; //(limit value is -1.2)
            double counter1; // counter for imagCoord values



            // initialize starting and ending values of realCooord (x-axis)

             double? startRealCoord = null; //(limit value is -0.6)
            double? endRealCoord = null; //(limit is 1.77)
            double counter2; // counter for realCoord values

            // initialize input based on string values

            string sImagCoordi = null;
           string sImagCoordf = null;

            string sRealCoordi = null;
            string sRealCoordf = null;

            // user prompt that will allow a number range to be put in for imagCoord
         //   Console.WriteLine("Enter starting and ending imagCoords, cannot be higher than 1.2, or lower than -1.2  ");
         //   sImagCoordi = Console.ReadLine();// read input for starting limit of ImagCoord
         //   sImagCoordf = Console.ReadLine(); // read input for ending limit of ImagCoord

           // startImagCoord = double.Parse(sImagCoordi); // converting the string into a double for starting value
         //   endImagCoord = double.Parse(sImagCoordf); // converting string input into a value got ending value

            // converting the counter to double to allow decimal numbers and will create counter for the y-axis
          //  counter1 = (double)(endRealCoord - startRealCoord) / 48;

            // user prompy - realCoord
          //  Console.WriteLine("Enter starting and ending values of realCoords, cannot be lower than -0.6 or higher than 1.77");
         //   sRealCoordi = Console.ReadLine(); // reads the user input for the starting value of realCoord
          //  sRealCoordf = Console.ReadLine(); // reads the user input line for the ending value of realCoord 

         //   startRealCoord = double.Parse(sRealCoordi); // converts the starting value into a double for the user input
           // endRealCoord = double.Parse(sRealCoordf); // converts the ending value into a double for user input

            // converting the counter to double to allow decimal numbers and will create counter for the x-axis
          //  counter2 = (double)(startRealCoord - endRealCoord) / 60;




            // Attempted to put 

           /* if ((startImagCoord > 1.2 || endImagCoord < -1.2) && (startRealCoord < -0.6 || endRealCoord > 1.77))
            {
                Console.WriteLine("Will Not Load images");


            }
            else
            {
                while ((startImagCoord < 1.2 || endImagCoord > -1.2) && (startRealCoord > -0.6 || endRealCoord < 1.77)
                    && (counter1 == (double)(endRealCoord - startRealCoord) / 48) || (counter2 == (double)(startRealCoord - endRealCoord) / 80))
                { */



                       for (imagCoord = 1.2; imagCoord >= -1.2; imagCoord -= 0.05)
                       {
                           for (realCoord = -0.6; realCoord <= 1.77; realCoord += 0.03)

                           {
                               iterations = 0;
                               realTemp = realCoord;
                               imagTemp = imagCoord;
                               arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                               while ((arg < 4) && (iterations < 40))
                               {
                                   realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                                      - realCoord;
                                   imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                                   realTemp = realTemp2;
                                   arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                                   iterations += 1;
                               }
                               switch (iterations % 4)
                               {
                                   case 0:
                                       Console.Write(".");
                                       break;
                                   case 1:
                                       Console.Write("o");
                                       break;
                                   case 2:
                                       Console.Write("O");
                                       break;
                                   case 3:
                                       Console.Write("@");
                                       break;
                               }
                           }
                           Console.Write("\n");
                       }  
                //}

            }

        }
    }

