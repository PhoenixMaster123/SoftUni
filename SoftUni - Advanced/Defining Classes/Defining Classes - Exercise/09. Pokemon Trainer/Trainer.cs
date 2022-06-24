using System;
using System.Collections.Generic;
using System.Text;

namespace _9.Pokemon_Trainer
{
    public class Trainer
    {
        public string  Name { get; set; }

        public int Badges { get; set; }

        public List< Pokemon > Pokemons { get; set; }

        public Trainer(string name)
        {
            Name = name;
            Badges = 0;
            Pokemons = new List<Pokemon>();
        }
    }
}
