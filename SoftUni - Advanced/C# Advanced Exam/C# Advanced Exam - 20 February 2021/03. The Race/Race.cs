using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        List<Racer> Data;
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Race(string name,int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Data = new List<Racer>();
        }
        public void Add(Racer racer)
        {
            if(this.Data.Count < this.Capacity)
            {
                 this.Data.Add(racer);
            }           
        }
        public bool Remove(string name)
        {
            if (this.Data.Any(x => x.Name == name))
            {
                this.Data.RemoveAll(x => x.Name == name);
                return true;
            }
            else
            {
                return false;
            }           
        }
        public Racer GetOldestRacer()
        {
            var oldestRacer = this.Data.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldestRacer;
        }
        public Racer GetRacer(string name)
        {
            if(this.Data.Any(x=>x.Name == name))
            {
                var racer = this.Data.Find(x => x.Name == name);
                return racer;
            }
            else
            {
                return null;
            }
        }
        public Racer GetFastestRacer()
        {

           var fastestCar = this.Data.OrderByDescending(x=>x.Car.Speed).FirstOrDefault();
           return fastestCar;
        }
        public int Count => this.Data.Count;
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {this.Name}:");
            foreach(var item in this.Data)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
