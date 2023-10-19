using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14_Classy
{

    public abstract class MyClass
    {
        private string myString;

        public string MyString
        {
            get
            {
                return myString;
            }
            set
            {
                myString = value;
            }
        }


        public interface IClass
        {
             void DrawMe();
        }

        public class MyClass2 : IClass
        {
            public void DrawMe()
            {
                Console.WriteLine("Hello World!");
            }
        }

        public class MyClass3 : IClass
        {
            public void DrawMe()
            {
                Console.WriteLine("GoodBye World!");
            }
        }

     

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // my error :(
        //  MyClass2 myClass = new MyClass2 
        }

        public static void MyMehtod(object MyObject)
        {
            
        }
    }
}
