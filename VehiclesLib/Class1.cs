using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Nana Sarpong
// PE11 - Question 5
// 	Write code in a class library project (.NET .DLL) called Vehicles that implements the Vehicle family of objects as outlined below 
// Errors: None
namespace VehiclesLib
{

    // creating a public interface called IPassengerCarrier
    public interface IPassengerCarrier
    {
        // method for interface
        void LoadPassenger();
    }

    // creating another public interface called IHeavyLoader
    public interface IHeavyLoadCarrier
    {

    }

    // Abstract Class called Vehicle  - will be treated as a parent class
    public abstract class Vehicle
    {
        // virtual method for abstract class
        public virtual void LoadPassenger() { 
        
        }

        // a child class (Car) being derived from our parent (base) abstract class Vehicle
        public abstract class Car : Vehicle
        {
            // Compact car child class being derived from its parent class Car and from interface IPassengerCarrier
            public class Compact : Car, IPassengerCarrier
            {
                 
            }

            // SUV child class being derived from it's parent class Car, and referencing IPassengerCarrier interface 
            public class SUV : Car, IPassengerCarrier
            {

            }

            // pickup chilc class being derived from its parent class Car and  two interfaces in our program
            public class PickUp : Car, IPassengerCarrier, IHeavyLoadCarrier 
            {

            }
        }

        // an abstract class called Train being derived from its parent function Vehicle
        public abstract class Train : Vehicle
        {
            // child class PassengerTrain being derived from its parent Train and interface IPassengerCarrier
            public class PassengerTrain : Train, IPassengerCarrier
            { 

            } 

            // child class FreightTrain being derived from its parent class Train and an interface called IHeavyLoadCarrier
            public class FreightTrain : Train, IHeavyLoadCarrier
            {

            }

            // child class _434DoubleBogey being derived from its parent class Train and the IHeavyLoadCarrier interface
            public class _424DoubleBogey : Train, IHeavyLoadCarrier
            {

            }
        }
    }

   
    
}
