using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }
        public override void Drive(double kilometers)
        {
            DefaultFuelConsumption = 8;
            //this.Fuel -= this.FuelConsumption = 8 * kilometers;
            this.Fuel -= DefaultFuelConsumption * kilometers;

        }
    }
}
