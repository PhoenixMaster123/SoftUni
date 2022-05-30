using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string command = Console.ReadLine();
            while(command !="End")
            {



                command = Console.ReadLine();
            }
        }
        class Vehicle
        {
            public Vehicle(string type, string model, string color, int horsePower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.HorsePower = horsePower;
            }
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }

        }
        
    }
}
