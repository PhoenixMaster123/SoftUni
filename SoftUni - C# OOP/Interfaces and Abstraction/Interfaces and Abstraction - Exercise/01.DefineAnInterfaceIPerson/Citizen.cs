using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson
    {
        //No validations -> use auto-properties (short)
        //Validation -> use full properties + fields (long)
        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        } 
        public string Name { get; private set; }
        public int Age { get; private set; }
     

    }
}
