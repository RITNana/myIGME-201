using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test_1_Scratchwork
{

    // Nana Sarpong
    // Question 12
    // Errors: didn't finish
    internal class Program
    {


      // Write a console application that has the following variable declarations:
        static void Main(string[] args)
        {
            string sName = ""; // user name input
            double dSalary = 30000;

            Console.Write("Enter name: "); // console prompt 
            sName = Console.ReadLine(); // read input from user
            GiveRaise(sName, ref dSalary); // call function for matching name and increasing raise 


        }

        // The function should increase the salary by $19,999.99 if name = your name and return true
       // Otherwise it should return false.
        static bool GiveRaise(string name, ref double salary)
        {

        }

    }
}

