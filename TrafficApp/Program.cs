using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesLib;



namespace TrafficApp
{
    // Nana Sarpong
    // PE11 - Question 6
    // Create a console application project, Traffic, which references Vehicles.dll 
    // Errors: none
    static internal class Program 
    {
        // declare an interface object set equal to a new class that is DERIVED from the interface IPassengerCarrier
        static void Main(string[] args)
        {
            //Vehicle.Car.Compact carone = new Vehicle.Car.Compact();
            IPassengerCarrier cartwo = new Vehicle.Car.Compact();
            AddPassenger(cartwo);

          //  IPassengerCarrier carthree = new Vehicle.Train.FreightTrain();
         // the error I would get is FreightTrain cannot be impliclty converted to a typeof IPassengerCarrier instance 

            
        }

        // vehicleObj is a paramater for the interface object from IPassengerCarrier
         static void AddPassenger(IPassengerCarrier vehicleObj)
        {
            vehicleObj.LoadPassenger(); // call the method from the interface
            Console.WriteLine("Works"); // test to see if reference worked
            Console.WriteLine(vehicleObj.ToString()); // call toString() from System.Object
            
        }
    }
}
