using _01._Vehicles.Core;
using _01._Vehicles.Factories;
using _01._Vehicles.Factories.Interfaces;
using _01._Vehicles.Models;
using System;

namespace _01._Vehicles
{
     public class StartUp
    {
        static void Main(string[] args)
        {
           
            string[] car = Console.ReadLine().Split(" ");
            string[] truck = Console.ReadLine().Split(" ");
            IVehicleFactory vehicleFactory = new VehicleFactory();
            Vehicle carData = vehicleFactory.CreateVehicle(car[0], double.Parse(car[1]), double.Parse(car[2]));
            Vehicle truckData = vehicleFactory.CreateVehicle(truck[0], double.Parse(truck[1]), double.Parse(truck[2]));

            IEngine engine = new Engine(carData, truckData);
            engine.Start();
        }
    }
}
