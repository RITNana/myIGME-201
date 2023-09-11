using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Sarpong_PE4
{
    internal class Program
    {
        // Nana Sarpong
        // PE4 - Question #1 & #2
        // user inputs two numbers and if they are both greater than 10, program asks user to enter new numbers

        static void Main(string[] args)
        {

            // store two integers in two variables
            // testing truth table 
            // int var1 = 1;
            // int var2 = 2;

            int? var1 = null; // this integer holds my first variable
            int? var2 = null; // this integer holds my second variable

            string sVar1 = ""; // first variable user input
            string sVar2 = ""; // second variable user input

            // prompt user to let them type in their first number 

            Console.Write("Input the first number, preferabbly not greater than 10: ");
            sVar1 = Console.ReadLine(); // read the inputted number from previous line

            // prompt user to let them type in their second number

            Console.Write("Input the second number, preferabbly not greater than 10: ");
            sVar2 = Console.ReadLine(); // read the inputted second number from previous line of code 

            // convert the input of the numbers (string) to integer values
            var1 = int.Parse(sVar1);
            var2 = int.Parse(sVar2);



            if ((var1 > 10 && var2 > 10)) // if both numbers are bigger than 10
            {
                Console.WriteLine("Enter two new numbers again: "); // Try again 
                sVar1 = Console.ReadLine();
                sVar2 = Console.ReadLine();
            }
            
            if ((var1 > 10) && (var2 < 10) || (var1 < 10) && (var2 > 10)) // if var1 is bigger than 10 and var2 isnt and vice versa
            {
                // will let user know the numbers did indeed work
                Console.WriteLine("You have entered numbers" + var1 + " and " + var2 + ". Success!"); 
            }

            else if (!(var1 > 10 && var2 > 10)) // if neither var1 or var2 is bigger than 10
            {
                // will let user know the numbers were accepted
                Console.WriteLine("You have entered numbers " + var1 + " and " + var2 + ". Success!");
            }















            // Scratchwork for Question 1 
            // leading into question 2

            /* if(var1 > var2 && 10 < var2)
             {
                 Console.WriteLine(true);
             } else
             {
                 Console.WriteLine(false);
             }

             if (var1 > var2 || 10 > var2)
             {
                 Console.WriteLine(true);
             }
             else
             {
                 Console.WriteLine(false);
             }

             if (var1 < var2 || 10 < var2)
             {
                 Console.WriteLine(true);
             }
             else
             {
                 Console.WriteLine(false);
             }

             if (var1 < var2 && 10 > var2)
             {
                 Console.WriteLine(false);
             }
             else
             {
                 Console.WriteLine(true);
             }
            */










            /*   int i;
            /*   for (i = 1; i <= 10; i++)
               {
                   if ((i % 2) = 0)
                   {
                       continue;
                   }

                   Console.WriteLine(i);
               }/*

               int number = 4;
               switch (number)
               {
                   case 1:
                       Console.WriteLine("Just");
                       break;

                   case 2:
                   case 4:
                       Console.Write("an");
                       break;

                   default:
                       Console.WriteLine("example");
                       break;
               }

               Console.Write(" example!");


               string favoriteFood = "spaghetti";
               switch (favoriteFood)
               {
                   case ("spaghetti"):
                       Console.WriteLine("You seem to really like spaghetti");
                       break;
                   case ("cake"):
                       Console.WriteLine("Wrong. Spaghetti is the best food.");
                       break;

                       default:  
             Console.WriteLine("You should like spaghetti.");
                       break;
               }
            */








        }
    }
}

