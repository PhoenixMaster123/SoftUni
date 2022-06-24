using System;
using System.Collections.Generic;
using System.Text;

namespace _9.Pokemon_Trainer
{
    public class Pokemon
    {
        public string  Name { get; set; }

        public string Element { get; set; }

        public int Health { get; set; }

        public Pokemon(string name, string element, int health)
        {
            Name = Name;
            Element = element;
            Health = health;
        }
    }
}
