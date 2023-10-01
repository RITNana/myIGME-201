using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sNumber = null;
            int nNumber = 0;
            int nAnswer = 0;

            do
            {
                Console.Write("Enter a positive integer: ");
                sNumber = Console.ReadLine();
            } while (!int.TryParse(sNumber, out nNumber) && nNumber <= 0);

            nAnswer = 1;

            while (nNumber > 0)
            {
                nAnswer *= nNumber;
                --nNumber;
            }

            nAnswer = Factorial(nNumber);
        }

        static int Factorial(int nNumber)
        {
            int nAnswer = 1;

            if (nNumber == 0)
            {
                nAnswer = 1;
            }
            else
            {
                nAnswer = nNumber * Factorial(nNumber - 1);
            }
            return (nAnswer);
        }
      //  Factorial(2) = 2 * f(1) :waiting at line 44
      //  Factorial(1) = 1 * f(0) : waiting at line 44
     //   Factorial(0) = 1 
      //  Factorial(1) = 1 * 1 = 1
      //  Factorial(2) = 2 * 1 = 2
    }
}
