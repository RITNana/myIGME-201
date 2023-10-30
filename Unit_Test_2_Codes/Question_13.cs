using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test_2_Codes
{
    // Nana Sarpong
    // 13.	Write the required method in the class MyClass and the code to make a shallow copy of objectA into objectB
    // No errors
    public class My_Class : ICloneable
    {
        public int intA; // field member intA
        public int intB; // field member intB

        // set constructors
        // params: integer value constructors 
        public My_Class(int intA, int intB)
        {
            this.intA = intA; // set constructor for intA
            this.intB = intB; // set constructor for intB
        }

        // Set the clone method fro objects to return the MemberwiseClone method for creating copies of object instances
        public Object Clone()
        {
           return MemberwiseClone();
        }
    }
   /* internal class Class2
    {
        static void Main(string[] args)
        {
            My_Class objectA = new My_Class(2, 3);
            My_Class objectB = new My_Class(1, 2);
            objectB = (My_Class)objectA.Clone();
            Console.WriteLine(objectB.intA);
        }
    } */
}
