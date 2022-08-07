using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    internal class SkiRental
    {
        List<Ski> Data;
        public string Name { get; set; }
        public int Capacity { get; set; }

        public SkiRental(string name,int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Data = new List<Ski>();
        }
        public string Add(Ski ski)
        {
            if (this.Data.Count < this.Capacity) // >=
            {
               Data.Add(ski);
            }
            return Data.ToString();
        }
        public bool Remove(string manufacturer, string model)
        {
            if(this.Data.Any(x => x.Manufacturer == manufacturer && x.Model == model))
            {
                this.Data.RemoveAll(x => x.Manufacturer == manufacturer && x.Model == model);
                return true;
            }
            else
            {
                return false;
            }
          

        }
        public Ski GetNewestSki()
        {
            Ski ski = this.Data.OrderByDescending(x => x.Year).FirstOrDefault();
            if(this.Data.Any())
            {
                return ski;
            }
            else
            {
                return null;
            }
        }
        public Ski GetSki(string manufacturer, string model)
        {
            Ski ski = this.Data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
            if(this.Data.Any())
            {
                return ski;
            }
            else
            {
                return null;
            }
        }
        public int Count => this.Data.Count;
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {this.Name}:");
            foreach(var ski in this.Data)
            {
                sb.AppendLine(ski.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
