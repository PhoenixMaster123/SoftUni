using _01._Vehicles.Factories.Interfaces;
using _01._Vehicles.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace _01._Vehicles.Factories
{
    using System;

    using Interfaces;
    using Models;
    public class VehicleFactory : IVehicleFactory
    {
        public Vehicle CreateVehicle(string vehicleType, double fuelQuantity, double fuelConsumtion)
        {
            Vehicle vehicle;
            if(vehicleType == "Car")
            {
                vehicle = new Car(fuelQuantity, fuelConsumtion);
            }
            else if(vehicleType == "Truck")
            {
                vehicle = new Truck(fuelQuantity, fuelConsumtion);
            }
            else
            {
                throw new InvalidOperationException("Invalid vehicle type!");
            }
            return vehicle;
        }
    }
}
