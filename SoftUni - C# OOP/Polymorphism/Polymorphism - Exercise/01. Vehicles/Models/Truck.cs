using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Vehicles.Models
{
    public class Truck : Vehicle
    {

        private const double IncrementBenzinTruck = 1.6;
        private const double RefuelCoeffiecient = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {

        }

        protected override double FuelConsumptionModifier => IncrementBenzinTruck;

        public override void Refuel(double liters)
        {
            base.Refuel(liters * RefuelCoeffiecient);
        }
    }
}
        //private const double IncrementBenzinTruck = 1.6;
        //private const double RefuelCoefficient = 0.95;
        //public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        //{

        //}

        //public override double FuelConsumption
        //{
        //    get
        //    {
        //        return base.FuelConsumption;
        //    }
        //    protected set
        //    {
        //        base.FuelConsumption = value + IncrementBenzinTruck;
        //    }
        //}
        //public override void Refuel(double litters)
        //{
        //    base.Refuel(litters * RefuelCoefficient);
        //}
        //protected override double FuelConsumptionModifier => IncrementBenzinTruck; // -> other Variant
    

