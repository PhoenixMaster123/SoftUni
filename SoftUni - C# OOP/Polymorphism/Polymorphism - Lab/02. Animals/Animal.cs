using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public Animal (string name,string food)
        {
            this.Name = name;
            this.Food = food;
        }
        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.Food}";
        }
    }
}
