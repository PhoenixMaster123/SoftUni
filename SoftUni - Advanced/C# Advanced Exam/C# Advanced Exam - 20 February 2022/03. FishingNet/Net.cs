using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        public List<Fish> Fish { get; private set; }
        public string Material { get; set; }
        public int Capacity { get; set; }
        public Net(string Material, int capacity)
        {
            this.Material = Material;
            this.Capacity = capacity;
            this.Fish = new List<Fish>();
        }
        public int Count => Fish.Count;
        
        public string AddFish(Fish fish)
        {
            if (string.IsNullOrWhiteSpace(fish.FishType) || fish.Weight <= 0 || fish.Length <= 0)
            {
                return $"Invalid fish.";
            }
            if (Fish.Count + 1 > Capacity)
            {
                return "Fishing net is full.";
            }
            this.Fish.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";
        }
        public bool ReleaseFish(double weight)
        {
            Fish fish = this.Fish.FirstOrDefault(x => x.Weight == weight);
            if (Fish.Contains(fish))
            {
                this.Fish.Remove(fish);
                return true;
            }
            else
            {
                return false;
            }

        }
        public Fish GetFish(string fishType)
        {
            Fish fish = this.Fish.FirstOrDefault(x => x.FishType == fishType);
            return fish;
        }
        public Fish GetBiggestFish()
        {
            var longestFish = this.Fish.Max(e => e.Length);
            Fish fish = this.Fish.FirstOrDefault(x => x.Length == longestFish);
            return fish;
        }
        public string Report()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {this.Material}:");

            foreach (var item in Fish.OrderByDescending(x => x.Length))
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();

        }
    }
}
