using System;


namespace Sarpong_PE1
{
    // the name of our class which is set to a default name called Program
    static internal class Program
    {
        // our method called Main which allows our code to be processed 
        static void Main(string[] args)
        {
            Console.WriteLine("Nana Sarpong");

            // using "let" in C# is not possible as it is the wrong syntax for this program
            // console.log doesn't work either, but .WriteLine is the same function

            string sMyName = "";
            Console.Write("What Is Your name?");

            // ReadLine needs to be initialized to a variable
          //  sMyName = Console.ReadLine();
            bool bMyNameIsNana = true;

            if (bMyNameIsNana == true)
            {
                Console.WriteLine("My Middle name is Kofi");
            }


            // for loops still work regularly
            // still need to replace "let" with int
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
