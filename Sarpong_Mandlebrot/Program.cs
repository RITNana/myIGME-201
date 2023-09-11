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
        static void Main(string[] args)
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;

            // initialize starting and ending values of imageCoord (y-axis)

            double? startImagCoord = null; //(limit value is 1.2)
             double? endImagCoord = null; //(limit value is -1.2)
             double increment1;



            // initialize starting and ending values of realCooord (x-axis)

            double? startRealCoord = null; //(limit value is -0.6)
             double? endRealCoord = null; //(limit is 1.77)
             double increment2;

            // initialize input based on string values

             string sImagCoordi = null;
             string sImagCoordf = null;

             string sRealCoordi = null;
             string sRealCoordf = null;

            // user input - imagCoord
            Console.WriteLine("Enter starting and ending imagCoords, cannot be higher than 1.2, or lower than -1.2  ");
            sImagCoordi = Console.ReadLine();
            sImagCoordf = Console.ReadLine();

            startImagCoord = double.Parse(sImagCoordi);
            endImagCoord = double.Parse(sImagCoordf);

            increment1 = Convert.ToDouble((endImagCoord - startImagCoord) / 48);

            // user input - realCoord
            Console.WriteLine("Enter starting and ending values of realCoords, cannot be lower than -0.6 or higher than 1.77");
            sRealCoordi = Console.ReadLine();
            sRealCoordf = Console.ReadLine();

            startRealCoord = double.Parse(sRealCoordi);
            endRealCoord = double.Parse(sRealCoordf);

            increment2 = (double)(startRealCoord - endRealCoord) / 2;





            if ((startImagCoord > 1.2 || endImagCoord < -1.2) && (startRealCoord < -0.6 || endRealCoord > 1.77))
            {
                Console.WriteLine("Will Not Load images");
            }
            else
            {
                   for(startImagCoord = 0; )
                // for (imagCoord = 1.2; imagCoord >= -1.2; imagCoord -= 0.05)
                {
                   // for (realCoord = -0.6; realCoord <= 1.77; realCoord += 0.03)
                   for (realCoord = -0.6; )
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
            }

        }
    }
}
