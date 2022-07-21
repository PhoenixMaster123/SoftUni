using System;
using System.Collections.Generic;
using System.Text;


namespace _01._Vehicles.Factories.Interfaces
{
    using Models;
    public interface IVehicleFactory
    {
        Vehicle CreateVehicle(string vehicleType,double fuelQuantity,double fuelConsumtion);
    } 
}
