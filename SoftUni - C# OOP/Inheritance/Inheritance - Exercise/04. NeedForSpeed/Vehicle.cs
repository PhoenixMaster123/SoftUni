using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public double DefaultFuelConsumption { get; set; }
        public virtual double FuelConsumption { get; set; }
        //{
            //get
            //{
            //    return DefaultFuelConsumption;
            //}
            //set
            //{
            //    DefaultFuelConsumption = value;
            //}
         //}
        
            
        public double Fuel { get; set; }
        public int HorsePower { get; set; }

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public virtual void Drive(double kilometers)
        {
            this.DefaultFuelConsumption = 1.25;
           // this.Fuel -= FuelConsumption * kilometers;
           this.Fuel -= DefaultFuelConsumption * kilometers;
        }
    }
}
