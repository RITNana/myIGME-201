using System;


namespace Sarpong_PE6
{
    //SCORE: 100/100

    // Nana Sarpong
    /* Create a simple number guessing game. Your program will generate a random integer number between
     0 and 100 (inclusive) and a player will try to guess it. */ 
    internal class Program
    {
        // hold and compile code for program to run
        static void Main(string[] args)
        {

            // Method: Main
            // Purpose: A number guessing game
            // Restrictions: None

            Random rand = new Random(); // create a new random object
            int randomNumber = rand.Next(0, 101); // set bounds for random numbers

             Console.WriteLine(randomNumber); // output random number

            int tries = 0; // number of tries user takes
            string sNumber = ""; // string input of number
            int nNumber = 0; // interger output of string input
            bool bValid; // testing if valid

            for (tries = 1; tries <= 8; tries++)
            {
                do // run code while boolean prompt stands
                {
                    Console.WriteLine("Guess the number between 1 and 100"); // prompt the user to guess a number between 1 to 100
                    sNumber = Console.ReadLine(); // read user input
                    bValid = int.TryParse(sNumber, out nNumber); // if valid, will convert user's string number to an integer

                    if (!bValid)
                    {
                        Console.WriteLine("Please enter a VALID number"); // if not valid, will send a message (won't take away turn)
                        
                    }
                } while (!bValid); 
                if ((nNumber >= 0) && (nNumber < 100)) // if between the ranges
                {
                    if (nNumber < randomNumber) // if number guessed is less than the randomNumber
                    {
                        Console.WriteLine("Your guess was too low");
                      
                    }
                    else if (nNumber > randomNumber) // if number guessed is greater than randomNumber
                    {
                        Console.WriteLine("Your guess was too high");
                     
                    }
                    else if (nNumber == randomNumber) // if they got the randomNumber right
                    {
                        Console.WriteLine("Correct!");

                    }
                    if ((nNumber == randomNumber) && (tries < 8)) // if they got it right in less than 8 tries
                    {
                        Console.WriteLine($"You won in {tries} turns ");
                        break; // stop code once they got it right in less than 8 tries
                    }
                }

               


            }
            // if they didn't get it right and used up all theri turns, state correct answer and end game
            if ((nNumber < randomNumber) || (nNumber > randomNumber) || (tries == 8)) 
            {
                Console.WriteLine("I'm sorry, the answer is: " + randomNumber);

            } else
            {

            }




        }
    }
}
