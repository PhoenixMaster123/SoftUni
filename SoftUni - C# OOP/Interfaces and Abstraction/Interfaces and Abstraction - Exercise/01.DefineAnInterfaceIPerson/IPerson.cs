using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    // Convetion -> Most of the interfaces shoud be public 
    // Define public side of our class: propetries (getter,setter) , methods
    public interface IPerson
    {
        public string Name { get; }
        public int Age { get; }
    }
       
       
}
