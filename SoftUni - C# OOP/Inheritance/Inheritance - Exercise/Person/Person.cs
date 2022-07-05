using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person  // by default inheritate Object
    {

        // Fields are used only in getters and setters of the properties

        private string name; // we use them when we need make validation 
        private int age;

        public Person(string name, int age)
        {
            this.Name = name; 
            this.Age = age;
        }
        // Properties are used in Constructors, Methods, and public instances
        
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age // for override -> public virtual int Age
        { 
            get 
            {
                return this.age;
            } 
            set 
            {
                if (this.age < 0) // Validation
                {
                    this.age = 0;
                }
                else
                {
                    this.age = value;
                }
                
            }
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }


    }
}
