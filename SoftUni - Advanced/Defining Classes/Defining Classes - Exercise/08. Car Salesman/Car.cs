using System;
using System.Collections.Generic;
using System.Text;

namespace _8.Car_Salesman
{
    public class Car
    {
        public string  Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight { get; set; }

        public string  Color { get; set; }

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{Model}:");
            sb.AppendLine();
            sb.Append(Engine.ToString());
            sb.AppendLine();
            sb.Append(Weight == 0 ? "  Weight: n/a" : $"  Weight: {Weight}");
            sb.AppendLine();
            sb.Append(string.IsNullOrEmpty(Color) ? "  Color: n/a" : $"  Color: {Color}");
            return sb.ToString().TrimEnd();
        }
    }
}
