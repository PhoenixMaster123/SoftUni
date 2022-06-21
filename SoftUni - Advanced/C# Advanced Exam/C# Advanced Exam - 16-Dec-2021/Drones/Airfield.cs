using System;
using System.Collections.Generic;
using System.Linq;

namespace Drones
{
    public class Airfield
    {
        public List<Drone> Drones { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }

        public Airfield(string name, int capacity, double landingStrip)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.LandingStrip = landingStrip;
            this.Drones = new List<Drone>();
        }

        public int Count => this.Drones.Count(d => d.Available == true);

        public string AddDrone(Drone drone)
        {
            if (string.IsNullOrEmpty(drone.Name) ||
                string.IsNullOrEmpty(drone.Brand) ||
                drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone.";
            }

            if (this.Drones.Count >= this.Capacity)
            {
                return "Airfield is full.";
            }

            this.Drones.Add(drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }

        public bool RemoveDrone(string name)
        {
            int count = this.Drones.RemoveAll(d => d.Name == name);
            return count > 0;

            //bool found = false;
            //var newDrones = new List<Drone>();
            //foreach (var d in this.Drones)
            //{
            //    if (d.Name != name)
            //        newDrones.Add(d);
            //    found = true; 
            //}
            //this.Drones = newDrones;
            //return found;
        }

        public int RemoveDroneByBrand(string brand)
        {
            int count = this.Drones.RemoveAll(d => d.Brand == brand);
            return count;

            //int count = 0;
            //var newDrones = new List<Drone>();
            //foreach (var d in this.Drones)
            //{
            //    if (d.Brand != brand)
            //        newDrones.Add(d);
            //    count++; 
            //}
            //this.Drones = newDrones;
            //return found;
        }

        public Drone FlyDrone(string name)
        {
            Drone drone = this.Drones.FirstOrDefault(d => d.Name == name);
            if (drone == null)
                return null;
            drone.Available = false;
            return drone;
        }

        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> matchingDrones =
                this.Drones.Where(d => d.Range >= range).ToList();
            foreach (var d in matchingDrones)
            {
                d.Available = false;
            }
            return matchingDrones;
        }

        public string Report()
        {
            var dronesAvailable = this.Drones.Where(d => d.Available == true);
            return
                $"Drones available at {this.Name}:" + Environment.NewLine +
                string.Join(Environment.NewLine, dronesAvailable);
        }
    }
}
