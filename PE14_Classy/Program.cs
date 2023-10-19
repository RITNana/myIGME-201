using PE14_Classy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Nana Sarpong
// PE14
// Professor Warth
// Errors - None
namespace PE14_Classy
{
    // create a public abstract class that defines a field memeber and has a read-write property
    public abstract class MyClass
    {
        // define our field member
        private string myString;

        // define property
        public string MyString
        {
            get
            {
                return myString; // read myString value
            }
            set
            {
                myString = value; // set myString value
            }
        }
    }

    // define out public interface to create a contract and define a method
    public interface IClass
    {
        void DrawMe(); // method that will be inherited for our classes
    }

    // Inherit from the interface and call its DrawMe method
    public class Class2 : IClass
    {
        // method from interface
        public void DrawMe()
        {
            Console.WriteLine("Hello World!"); // output a line the console
        }
    }

    // Inherit from the interface and call its DrawMe method
    public class Class3 : IClass
    {
        // method from interface 
        public void DrawMe()
        {
            Console.WriteLine("Goodbye World!"); // output a line the console
        }
    }




}
// Create objects of our two classes and call the MyMethod to use their DrawMe methods
internal class Program
{
    // set objects to out main program
    static void Main(string[] args)
    {
        Class2 class2 = new Class2(); // object for Class2
        Class3 class3 = new Class3(); // object for class3
        MyMethod(class2); // MyMethod method with our class2 object set as paramter to call DrawMe method
        MyMethod(class3); // MyMethod method with our class2 object set as paramter to call DrawMe method
    }

    // MyMethod is meant to pass in an object as a parameter and to call the DrawMe common method through our interface
    public static void MyMethod(object myObject)
    {
        IClass iclass = (IClass)myObject; // Cast our interface for our myObject parameter
        iclass.DrawMe(); // call the common method 
    }
}
