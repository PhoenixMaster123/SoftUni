﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    class Pizza
    {
        private const int MIN_LENGHT = 1;
        private const int MAX_LENGHT = 15;
        private const int MIN_TOPPING = 0;
        private const int MAX_TOPPING = 10;

        private string name;
        private Dough dough;
        private List<Topping> Toppings;
        public Pizza(string name)
        {
            this.Name = name;
            this.Toppings = new List<Topping>();
        }

        public string Name
        {
            get 
            {
                return this.name;
            }

            private set
            {
                if (value.Length < MIN_LENGHT || value.Length > MAX_LENGHT)
                {
                    throw new ArgumentException($"Pizza name should be between {MIN_LENGHT} and {MAX_LENGHT} symbols.");
                }
                this.name = value;
            }
        }

        public Dough Dough
        {
            set
            {
              this.dough = value;
            }
        }
        public void AddTopping(Topping top)
        {
            int count = this.Toppings.Count;
            if (count < MIN_TOPPING || count > MAX_TOPPING)
            {
                throw new ArgumentException($"Number of toppings should be in range [{MIN_TOPPING}..{MAX_TOPPING}].");
            }
            this.Toppings.Add(top);
        }
        public string TotalCalories()
        {
            double toppingCalories = this.Toppings.Sum(x => double.Parse(x.Calories()));
            double doughCalories = double.Parse(this.dough.Calories());

            return (toppingCalories + doughCalories).ToString("F2");
        }
    }
}
