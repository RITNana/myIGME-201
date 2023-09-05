using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarpong_PE3
{

    namespace fabulous
    {
        // code in fabulous namespace
       
    }

    namespace super
    {
        namespace smashing
        {
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        { 
            int num1 = 2;
            string number = "3.50";
            int num2 = 4;
            int num3 = 5;
            num1 = num1 * num3;
            num2 = num1 / num2;
            num3 = num3 % num2;

            Console.Out.WriteLine("50 plus 25 is " + 50 + 25);
        }
    }
}
