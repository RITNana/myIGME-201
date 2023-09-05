using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ColorsAndNumbers
{
    namespace Colors
    {
        enum EColors
        {
            red,
            orange,
            yellow,
            green,
            blue,
            indigo,
            violet
        }
    }

    namespace Numbers
    {
        enum ENumbers
        {
            one,
            two,
            three,
            four,
            five,
            six,
            seven
        }

    }
}


namespace FavoriteColorAndNumber
{

    using ColorsAndNumbers.Colors;

    using ColorsAlias = ColorsAndNumbers.Colors;


    static internal class Program
    {

        static void WriteMyVar (ref int nParameter)
        {
            Console.WriteLine(nParameter);

            nParameter = 42;

        }
        
        static void Main(string[] args)
        {
            ColorsAlias.EColors eColors;





            Console.WriteLine("");

            int myInt = 0;
            int anotherInt = 2;
            string sFavoriteColor = null;
            string sFavoriteNumber = "";
            bool bValid = false;
            int? nFavoriteNumber = null;


            anotherInt = myInt;

            WriteMyVar(ref myInt);

            // 3 errors
            // 1. syntax errors (missing semicolon)
            // 2. logical (code runs but doesn't do it right)
            // 3. runtime errors (code crashes!)


            // prompt the user for their favorite color
            Console.Write("Hello! Please enter your favorite color: ");

            // read the favorite color from the user and store it in a variable
            sFavoriteColor = Console.ReadLine();

            // prompt the user for their favorite number
            Console.Write("Please enter your favorite number: ");

            // read their favorite num into a variable
              sFavoriteNumber = Console.ReadLine();


            // while (bValid == false)
            //  {
            //  }

             while (nFavoriteNumber == null)
              {
                try
                {
                    nFavoriteNumber = Convert.ToInt32(sFavoriteNumber);
                }
                catch
                {
                    Console.WriteLine("Please enter an integer: ");
                    sFavoriteColor = Console.ReadLine();
                }
            }

            do
            {
                sFavoriteColor = Console.ReadLine();
                try
                {
                    nFavoriteNumber = Convert.ToInt32(sFavoriteNumber);
                }
                catch
                {
                    Console.WriteLine("Please enter an integer: ");
                    sFavoriteColor = Console.ReadLine();
                }
            } while (nFavoriteNumber == null);


            do
            {
                sFavoriteColor = Console.ReadLine();
                try
                {
                    sFavoriteNumber = "42";
                    // sFavoriteNumber + sFavoriteNumber != 84 ("4242")
                   // sFavoriteNumber.Length = 2;
                    nFavoriteNumber =int.Parse(sFavoriteNumber);
                }
                catch
                {
                    Console.WriteLine("Please enter an integer: ");
                    sFavoriteColor = Console.ReadLine();
                }
            } while (nFavoriteNumber == null);



            int nFavoriteNumberInt = 0;
            do
            {
                sFavoriteColor = Console.ReadLine();
                
                    // will convert the string variable to the interger dataype, which will come out as the integer variable set (out variable)
                    bValid = int.TryParse(sFavoriteNumber, out nFavoriteNumberInt);

                if (bValid == false) // same thing
                if (!bValid)
                {

                }
                
                
                {
                    Console.WriteLine("Please enter an integer: ");
                  
                }
            } while (nFavoriteNumber == null);
            nFavoriteNumber = nFavoriteNumberInt;





            {
                int myInt2 = 0;

                myInt = 3;
                myInt = 5;
                string myString = "";
            }
            //   myString = "David"; - not in code block


            // set favorite color to lower case
            // this won't change the string contents
            sFavoriteColor.ToLower();


            // change the console output color to match their favorite color
            switch (sFavoriteColor.ToLower())
            {
                case "red":
               // case "RED":
               // case "Red":
               // case "rEd":
              //  case "reD":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }






            int y = 0;
            int x = 5;
           // y = ++x; // increment x so that x = 6, y = 6
          //  y = x++; // y = 5, x = 6

            // a loop that outputs their favorite color fav num times
            for (int i = 0; i < nFavoriteNumber; i++)
            {
                Console.WriteLine("Your favorite color is " + sFavoriteColor + "!");
                Console.WriteLine($"Your favorite color is {sFavoriteColor +  "!"}"); // string interpolation
                Console.WriteLine("Your {0} favorite color is {1}{2}", "most", sFavoriteColor, "!");

                Console.WriteLine("5 + 5 = " + (x + x)); // 5 + 5 = 10
            }




        }
    }
}
