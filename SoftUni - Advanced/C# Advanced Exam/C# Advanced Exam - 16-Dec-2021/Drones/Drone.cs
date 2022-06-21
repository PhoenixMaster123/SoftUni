using System;

namespace Drones
{
    public class Drone
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Range { get; set; }
        public bool Available { get; set; } = true; // by default

        public Drone(string name, string brand, int range)
        {
            Name = name;
            Brand = brand;
            Range = range;
        }

        public override string ToString()
        {
            return
                   $"Drone: {this.Name}" + Environment.NewLine +              // do not use \r\n
                   $"Manufactured by: {this.Brand}" + Environment.NewLine +
                   $"Range: {this.Range} kilometers";
        }
    }
}
