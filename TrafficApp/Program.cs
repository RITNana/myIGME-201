using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehiclesLib;



namespace TrafficApp
{
    static internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle.Car.Compact carone = new Vehicle.Car.Compact();
            IPassengerCarrier cartwo = new Vehicle.Car.Compact();
            AddPassenger(cartwo);

          //  IPassengerCarrier carthree = new Vehicle.Train.FreightTrain();
         // the error I would get is FreightTrain cannot be impliclty converted to a typeof IPassengerCarrier instance 

            
        }

         static void AddPassenger(IPassengerCarrier vehicleObj)
        {
            vehicleObj.LoadPassenger();
            Console.WriteLine("Works");
            Console.WriteLine(vehicleObj.ToString());
            
        }
    }
}
