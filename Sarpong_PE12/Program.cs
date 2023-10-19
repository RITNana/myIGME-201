using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Nana Sarpong
// PE12: Questions 1-3
// Errors: None
namespace Sarpong_PE12
{

    // define a public class called MyClass
    public class MyClass
    {
        // create a private field called MyString - should be done before method

        private string myString;
        

        // create a public virtual method called GetString
        public virtual string GetString()
        {
            // Should return the string stored in the private field  myString
            return myString;
            
        }

        // create a property called MyString and set it to a write-only property
        public string MyString
        {
            set
            {
                myString = value;
            }
        }


    }

    // derive MyDeruvedClass from MyClass 
    public class MyDerivedClass : MyClass
    {
        // override GetString method to return the string from the base (parent) method 
        public override string GetString()
        {
           string name = base.GetString(); // use base keyword to get the GetString method and initialize it to a string variable
          //  Console.WriteLine(name);
            return name + " Output from the derived class"; // return variable plus additional text
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass myDerivedClass = new MyDerivedClass(); // create a new MyDerivedClass instance object
            myDerivedClass.MyString = "Test"; // set the MyString property's myString data type to "Test"
            Console.WriteLine(myDerivedClass.GetString()); // Print the GetString method to console
        }
    }
}
