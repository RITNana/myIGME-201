using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CafeLib
{
    public interface IMood
    {
        string Mood { get; }
    }

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

    public class Customer : IMood
    {
        public string name;
        public string creditCardNumber;

        public string Mood
        {
            get { return name; }
        }


    }



    public interface ITakeOrders
    {
        void TakeOrder();
    }
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
