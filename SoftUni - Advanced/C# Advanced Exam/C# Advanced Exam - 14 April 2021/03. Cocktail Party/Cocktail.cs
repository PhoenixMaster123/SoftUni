using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        List<Ingredient> Ingredients;
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }
        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.MaxAlcoholLevel = maxAlcoholLevel;
            this.Ingredients = new List<Ingredient>();
        }
        public void Add(Ingredient ingredient)
        {
            if(!this.Ingredients.Contains(ingredient) && this.Ingredients.Count < this.Capacity && this.MaxAlcoholLevel > ingredient.Alcohol)
            {
                this.Ingredients.Add(ingredient);
               
            }
           
            
        }
        public bool Remove(string name)
        {
            if (this.Ingredients.Any(x => x.Name == name))
            {
                this.Ingredients.Remove(this.Ingredients.First(x => x.Name == name));
                return true;
            }
            return false;
        }
        public Ingredient FindIngredient(string name)
        {
            if (this.Ingredients.Any(x => x.Name == name))
            {
                return this.Ingredients.First(x => x.Name == name);
            }

            return null;
        }
        public Ingredient GetMostAlcoholicIngredient()
        {
            return this.Ingredients.OrderByDescending(x => x.Alcohol).First();
        }
        public int CurrentAlcoholLevel => this.Ingredients.Sum(x => x.Alcohol);
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {this.Name} - Current Alcohol Level: {CurrentAlcoholLevel}");
            foreach (var alkohol in Ingredients)
            {
                sb.AppendLine(alkohol.ToString());
            }
            return sb.ToString().TrimEnd();

        }
    }
}
