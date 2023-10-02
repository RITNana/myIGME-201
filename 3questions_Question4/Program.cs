using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace _3questions_Question4
{
    static internal class Program
    {
        // class-level variables that are available to every method in the class
        static System.Timers.Timer timeOutTimer; // create a Timer instance - name is timeOutTimer
        static bool timerCount = false; // timer boolean to set/reset timer


        static void TimesUp(object sender, ElapsedEventArgs e)
        {
            timerCount = true; // resets after a certain time interval
            Console.WriteLine();
            Console.WriteLine("Times Up!"); // times up message prompted by console
        }
        static void Main(string[] args)
        {
            string sChoice; // choose between ques 1-3
            int nChoice; // converted to int
            int nResponse = 0; // number response for question 2
            string sAnswer = ""; // answer for qiestions 1 and 3
            string sResponse = null; // user response for questions 1 and 3
            int nAnswer; // question 2

        start:

            timeOutTimer = new System.Timers.Timer(5000); // 5 second-timer
            timeOutTimer.Elapsed += new ElapsedEventHandler(TimesUp); // checks countdown for timer



            do
            {
                Console.Write("Choose your question (1-3): "); // console prompts user
                timeOutTimer.Start(); // timer starts
                sChoice = Console.ReadLine(); // console reads user input
                timeOutTimer.Stop(); // timer stops
                nChoice = Convert.ToInt32(sChoice);


                switch (nChoice)
                {
                    case 1:
                        Console.Write("What is your favorite color? ");
                        sResponse = Console.ReadLine(); // console will read response
                        sAnswer = "green"; // answer for question
                        if (sResponse == sAnswer)
                        {
                            Console.WriteLine("Well Done!"); // confirmation
                        }
                        else
                        {
                            Console.WriteLine("Wrong! The answer is " + sAnswer);
                        }
                        break;

                    case 2:
                        Console.Write("What is the answer to life, the universe, and everything");
                        sResponse = Console.ReadLine(); // console will read response
                        nResponse = Convert.ToInt32(sResponse); // convert answer to int
                        nAnswer = 42; // actual
                        if (nResponse == nAnswer)
                        {
                            Console.WriteLine("Well Done!");
                        }
                        else
                        {
                            Console.WriteLine("Wrong! The answer is " + nAnswer);
                        }
                        break;

                    case 3:
                        Console.WriteLine("What is the airspeed velocity of an unladen swallow? ");
                        sResponse = Console.ReadLine(); // console reads response
                        sAnswer = "What do you mean? African or European Swallow?"; // answer
                        if (sResponse == sAnswer)
                        {
                            Console.WriteLine("Well Done!");

                        }
                        else
                        {
                            Console.WriteLine("Wrong! The answer is " + sAnswer);
                        }
                        break;

                }

            } while (!timerCount);






            string sAgain = "";
            // prompt if they want to play again
            Console.Write("Play again? ");

            sAgain = Console.ReadLine();

            // if they type yes then play again
            // else if they type n or no then leave this loop
            if (sAgain.ToLower().StartsWith("y"))
            {
                goto start;

            } else
            {
                
            }
        }
    }
}
           
        
        
    

