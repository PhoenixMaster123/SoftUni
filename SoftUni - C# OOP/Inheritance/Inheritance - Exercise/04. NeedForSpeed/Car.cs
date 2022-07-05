using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
        public override void Drive(double kilometers)
        {
            DefaultFuelConsumption = 3;
            //this.Fuel -= this.FuelConsumption = 3 * kilometers;
            this.Fuel -= DefaultFuelConsumption * kilometers;
        }
    }
}
