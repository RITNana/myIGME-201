using System;
using System.Security.Policy;

namespace StructToClass
{
    // Nana Sarpong
    // Write a console application which converts the following code from using struct Friend
    // to public class Friend and generates the same output:

    // Nana Sarpong
    // Create a friend Class that inherits the clone interface for shallow copy
    // No errors
    public class Friend : ICloneable
    {
        public string name; // name of person
        public string greeting; // the greeting
        public DateTime birthdate; // day they were born
        public string address; // address

        public string Name
        {
            set
            {
                name = value; // set name of person
            }
        }


        public string Greeting
        {
            set
            {
                greeting = value; // set greeting statement
            }
        }

        public DateTime BirthDate
        {
            set
            {
                birthdate = value; // set birthdate value
            }
        }

        public string Address
        {
            set { address = value; } // set address 
        }

        public string GetName()
        {
            return name; // return name
        }

        public string GetGreeting()
        {
            return greeting; // return greeting 
        }

        public DateTime GetDataTime()
        {
            return birthdate; // return birthdate 
        }

        public string GetAddress()
        {
            return address; // return address 
        }

        public Object Clone()
        {
            return MemberwiseClone(); // create shallow copy 
        }
    } 

  
  

    class Program
    {

       

       /* static void Main(string[] args)
        {
            Friend friend = new Friend(); // creaye friend object
            Friend enemy = new Friend(); // create another friend class object called enemy

            // create my friend Charlie Sheen
            friend.Name = "Charlie Sheen"; // declare the name
           friend.Greeting = "Dear Charlie"; // declare the greeting
           friend.BirthDate = DateTime.Parse("1967-12-25"); // declare the birthdate
           friend.Address = "123 Any Street, NY NY 12202"; // declare address


            // now he has become my enemy
            enemy = (Friend)friend.Clone(); // clonse the friend class object to not lose data into enemy

            // set the enemy greeting and address without changing the friend variable
            enemy.Greeting = "Sorry Charlie"; // set name value for enemy
            enemy.Address = "Return to sender.  Address unknown."; // set address value for enemy

        // Display to the console
            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.GetGreeting()} => {enemy.GetGreeting()}");
            Console.WriteLine($"friend.address => enemy.address: {friend.GetAddress()} => {enemy.GetAddress()}"); 


           
        } */
    }
}
