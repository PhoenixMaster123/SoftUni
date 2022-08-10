﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SkiRental
{
    internal class Ski
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Ski(string manufacturer, string model,int year)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Year = year;
        }

        public override string ToString()
        {
            return $"{this.Manufacturer} - {this.Model} - {this.Year}";
        }
    }
}