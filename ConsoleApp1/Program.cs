using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double imagCoord;
            string imagCoordS = null;
            double counter;

            counter = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input two numbers: ");
            imagCoordS = Console.ReadLine();
            imagCoordS = Console.ReadLine();

            imagCoord = Convert.ToDouble(imagCoordS);

            Console.WriteLine(imagCoord - imagCoord);

            for (imagCoord = 0; imagCoord <= counter; imagCoord++)
            {
                Console.WriteLine("Hello!");
            }


            
            



        }
    }
}
