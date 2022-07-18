using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Border_Control
{
    public class Citizen : ICitizens
    {
        public string Name {  get; set; }

        public int Age { get; set; }

        public string Id { get; set; }

        public Citizen(string name,int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }
    }
}
