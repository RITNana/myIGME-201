using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

// Nana Sarpong
// PE16 - Classiest
//	Create a .NET Class Library called CafeLib.dll from the following schUML
// Errors: None
namespace CafeLib
{
    // interface to create a Mood contract that will relate to different classes in regards to restaurant service
    public interface IMood
    {
        string Mood { get; }
    }

    // class for waiter that is derived from the Mood interface, defines that a waiter will have a mood when serving
    public class Waiter : IMood
    {
        public string name;

        public string Mood
        {
            get { return name; }
        }

        public void ServeCustomer(HotDrink cup)
        {

        }
    }

    //class for customer that will alosn derive from Mood interface
    public class Customer : IMood
    {
        public string name;
        public string creditCardNumber;

        public string Mood
        {
            get { return name; }
        }


    }


    // interface to take orders and what orders they may be related to
    public interface ITakeOrders
    {
        void TakeOrder();
    }
    // abstract class to contain all properties in general for a hot drink and who is receving it
    public abstract class HotDrink
    {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;
        public Customer customer;

        public virtual void AddSugar(byte amount)
        {

        }

        public abstract void Steam();

        public HotDrink()
        {

        }

        public HotDrink(string brand)
        {

        }


    }

    // cup of coffee is a hot drink and is one of the orders that can be taken
    public class CupOfCoffee : HotDrink, ITakeOrders
    {
        public string beanType;

        public override void Steam()
        {

        }

        public void TakeOrder()
        {

        }

        public CupOfCoffee(string brand) : base(brand)
        {

        }
    }

    // cup of tea is a hot drink that is one of the orders that can be taken
    public class CupOfTea : HotDrink, ITakeOrders
    {
        public string leafType;

        public override void Steam()
        {

        }

        public void TakeOrder()
        {

        }

        public CupOfTea(bool customerIsWealthy)
        {

        }
    }

    // cup of cocoa with its ingredients and its classification as a hot drink (order can be taken for item)
    public class CupOfCocoa : HotDrink, ITakeOrders
    {
        public static int numCaps;
        public bool marshmellows;
        private string source;

        public string Source
        {
            set
            {
                source = value;
            }
        }

        public override void Steam()
        {
          
        }

        public override void AddSugar(byte amount)
        {
            
        }

        public void TakeOrder()
        {

        }

        public CupOfCocoa() : this(false)
        {
            
        }

        public CupOfCocoa(bool marshmellows) : base("Expensive Organic Brand")
        {

        }
    }
}
