using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.VehicleInterface
{
    public interface IVehicle
    {
        
        string Make { get; }
        string Model { get; }
        string Color { get; }
        string Start();
        string TurnOff();
        string Drive();

    }

    public class Motorcycle : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Start()
        {
            return "Vehicle on";
        }
        public string TurnOff()
        {
            return "Vehicle off";
        }
        public string Drive()
        {
            return "Your Driving";
        }
    }
}

// Komodo Insurance wants you to clean up some of their software by creating methods that use all of their different types of vehicles. Before that can be done, you know they need to make an interface that can be implemented on all of their classes. KI has all of their vehicle types (sedans, SUV, motorcycle, etc) sharing similar attributes and actions. All vehicles need to be able to start, turn off, drive, as well as they all have a make, model, and color.

//To demonstrate the benefits, make the interface and a few example classes. Write a few tests as well showing the power of the new interface.