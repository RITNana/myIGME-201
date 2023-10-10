using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

// Nana Sarpong
// Questions 3 and 5
namespace Sarpong_PE9
{






    struct Order
    {
        public string itemName; 
        public int unitCount;
        public double unitCost; 

        public double Bank(int unitCount, double unitCost) // create a function with parameters 
        {
            return  unitCount *  unitCost; // multiply returne dvalues of params
        }

        public string outPut(int unitCount, double unitCost) // create a string function
        {
            string answer = (unitCount + itemName + "items at" + unitCost + "each, total cost" + "$" + Bank(unitCount, unitCost)); // output statement 
            return answer; // return answer for total price;
        }
    }

    // Create a delegate function to impersonate Console.ReadLine()
    static internal class Program
    {


        /*  static bool Write()
          {
              Console.WriteLine("Text output from function.");
          }

          static void myFunction(string label, params int[] args,
           bool showLabel)
          {
              if (showLabel)
              {
                  Console.WriteLine(label);
              }

              foreach (int i in args)
              {
                  Console.WriteLine("{0}", i);
              }
          }*/

        // 3.	Create a delegate function and use it to impersonate the Console.ReadLine() function when asking for user input
        static void Main(string[] args)
        {

            Func<string> readInput; // refer to function called readInput
            readInput = Console.ReadLine; // set readInput to Console.ReadLine
             
            string input = readInput(); // set a string variable to our function

            Console.WriteLine(input); // print to console
           
        }
    }
}
