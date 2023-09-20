using System;
using System.Threading;


namespace MemoryGame
{
    static internal class Program
    {

        static Timer timeOutTimer;
        static bool bTimeOut = false;

        static void Main(string[] args)
        {



        start:

            string displayString = "";
            Random rand = new Random();
            Console.Clear();

            while(!bTimeOut)
            {
                displayString += (char)('A' + rand.Next(0, 26));
                foreach (char c in displayString)
                {
                    Console.Write(c);
                    System.Threading.Thread.Sleep(500);
                }

                Console.Clear();

               // timeOutTimer = new Timer(displayString.Length * 500 + 1000);


                
            }

                
              
        }
    }
}
