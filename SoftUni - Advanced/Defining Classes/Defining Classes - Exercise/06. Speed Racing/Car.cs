using System;
using System.Collections.Generic;
using System.Text;

namespace _6.Speed_Racing
{
    public class Car
    {
        public string  Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public bool Drive(double distanceTraveled)
        {
            double neededFuel = distanceTraveled 
                                * this.FuelConsumptionPerKilometer;
            if (neededFuel >this .FuelAmount)
            {
                return false;
            }

            this.FuelAmount -= neededFuel;
            this.TravelledDistance += distanceTraveled;
            return true;
        }
    }
}
