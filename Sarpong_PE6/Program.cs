using System;


namespace Sarpong_PE6
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Random rand = new Random();

            // generate a number from 0 (inclusive) to 101 (exclusive)
            int randomNumber = rand.Next(0, 101);
             Console.WriteLine(randomNumber);

            // generate a loop that runs for 8 tries for the user
            for (int i = 0; i <= 8; i++)
            {
                string sNumber = "";
                int nNumber = 0;
                bool bValid = false;
              //  int nCorrect = 0;

                // valid  and invalid entries
                int counterGood = 0;
                int counterBad = 0;
                
                do
                {
                    Console.WriteLine("Guess a number");
                    sNumber = Console.ReadLine(); // read user input and convert to integer
                    if (!bValid)
                    {
                        if (int.TryParse(sNumber, out nNumber))
                        {
                            if (nNumber >= 0 && nNumber <= 100)
                            {
                                if (nNumber == randomNumber)
                                {
                                    Console.WriteLine("Good Job! You got the number!");
                                    counterGood++;
                                } else
                                {
                                    counterBad++;
                                }  
                            } else 
                            {
                                Console.WriteLine("Invalid Answer, try again");
                                sNumber = Console.ReadLine();
                                counterBad++;
                            }
                            
                        }

            }
        }
    }
}
