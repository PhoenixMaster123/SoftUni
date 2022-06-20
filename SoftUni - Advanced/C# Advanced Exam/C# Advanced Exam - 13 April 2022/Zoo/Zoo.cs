using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        public List<Animal> Animals { get; private set; } // could not be modified
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Zoo(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Animals = new List<Animal>();
        }

        public string AddAnimal(Animal animal)
        {
            if(string.IsNullOrWhiteSpace(animal.Species))
            {
                return $"Invalid animal species.";
            }
            if (animal.Diet != "herbivore" && animal.Diet != "carnivore") 
            {
                return $"Invalid animal diet.";
            }
            if(this.Animals.Count >= this.Capacity)
            {
                return $"The zoo is full.";
            }
            this.Animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";
        }
        public int RemoveAnimals(string species)
        {
            int count = this.Animals.RemoveAll(a => a.Species == species);
            return count;
        }
        public List <Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> searchingAnimalByDiet  = this.Animals.Where(a => a.Diet == diet).ToList();
            return searchingAnimalByDiet;
        }
        public Animal GetAnimalByWeight(double weight)
        {
            Animal animal = this.Animals.FirstOrDefault(a => a.Weight == weight);
            return animal;
        }
        public string GetAnimalCountByLength(double minimumLength,double maximumLength)
        {
            List<Animal> counter = this.Animals.Where(x => (x.Length >= minimumLength) && (x.Length <= maximumLength)).ToList();
            return $"There are {counter.Count} animals with a length between {minimumLength} and {maximumLength} meters.";

        }


    }
}
