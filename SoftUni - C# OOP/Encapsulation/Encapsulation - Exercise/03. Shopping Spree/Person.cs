using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_Spree
{
    class Person
    {
        private string name;
        private decimal money;
        public List<Product> BagOfProducts { get; set; }

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.BagOfProducts = new List<Product>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }
        public string CanAfford(Product product)
        {
            if (this.Money >= product.Cost)
            {
                this.AddProduct(product);
                return $"{this.Name} bought {product.Name}";
            }
            else
            {
                return $"{this.Name} can't afford {product.Name}";
            }
        }
        private void AddProduct(Product product)
        {
            this.BagOfProducts.Add(product);
            this.Money -= product.Cost;
        }
        public override string ToString()
        {
            if (this.BagOfProducts.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }
            else
            {
                return $"{this.Name} - {string.Join(", ", this.BagOfProducts.Select(p => p.Name))}";

            }
        }
    }
}
