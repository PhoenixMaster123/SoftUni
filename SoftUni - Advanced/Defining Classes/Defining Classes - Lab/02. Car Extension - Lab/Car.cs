using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    internal class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            double fuelToConsume = distance * FuelConsumption;
            if (FuelQuantity - fuelToConsume >= 0)
            {
                FuelQuantity -= fuelToConsume;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
            /////////////////////////////////////////// First Variant /////////////////////////////
            
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}";

            /////////////////////////////////////////// Second Variant /////////////////////////////
            
            //StringBuilder result = new StringBuilder();

            //result.AppendLine($"Make: {this.Make}");
            //result.AppendLine($"Model: {this.Model}");
            //result.AppendLine($"Year: {this.Year}");
            //result.AppendLine($"Fuel: {this.FuelQuantity:F2}L");

            //return result.ToString().TrimEnd();

        }

    }
}
