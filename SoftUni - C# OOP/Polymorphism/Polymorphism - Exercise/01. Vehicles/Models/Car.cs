using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Vehicles.Models
{
    public class Car : Vehicle
    {
        //private const double IncrementBenzinCar = 0.9;
        //public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption) //+ IncrementBenzin -> First Variant
        //{

        //}
        //// Second Variant
        //public override double FuelConsumption 
        //{ 
        //    get 
        //    { 
        //        return base.FuelConsumption;
        //    }
        //    protected set 
        //    {
        //        base.FuelConsumption = value + IncrementBenzinCar; // second Variant
        //    }
        //}
        private const double IncrementBenzinCar = 0.9;

        public Car(double fuelQuantity, double fuelConsumption): base(fuelQuantity, fuelConsumption)
        {

        }

        protected override double FuelConsumptionModifier => IncrementBenzinCar;

    }
}
