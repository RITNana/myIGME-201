using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test_2_Codes
{
    // Nana Sarpong
    //Question 11 Code Practice 

    public class MyClass 
    {
        public int myInt;
        public MyClass(int nVal)
        {
            this.myInt += nVal;
        }

        public Object clone()
        {
            return MemberwiseClone();
        }
    }

    public class myDerivedClass : MyClass
    {
        public myDerivedClass(int nVal) : base(nVal) 
        {
            this.myInt = (this.myInt + 2) * 4;
        }
    }
   /* internal class Class1
   {
        static void Main(string[] args)
        {
            myDerivedClass obj = new myDerivedClass(42);
            Console.WriteLine(obj.myInt);
           







            SortedList<string, DateTime> friendBirthdays = new SortedList<string, DateTime>();

            friendBirthdays.Add("Sam", new DateTime(2003, 4, 16));
            friendBirthdays.Add("Johnny", new DateTime(2003, 1, 3));
            friendBirthdays.Add("Emily", new DateTime(2004, 6, 29));

            foreach(KeyValuePair<string, DateTime> valuePair in friendBirthdays) {
                Console.WriteLine($"person[{valuePair.Key}] = {valuePair.Value.ToString("MM/dd/yyyy")}");
            }
        }
    } */
} 
