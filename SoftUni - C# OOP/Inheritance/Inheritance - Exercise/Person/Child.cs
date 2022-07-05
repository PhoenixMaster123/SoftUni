using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        // I want to change the logic of the settet -> to have two validations 

        /////////////////////////////////////////////////////////////////// First Variant ////////////////////////////////
        //public override int Age 
        //{ get => base.Age; 
        //  set => base.Age = value; }
        /////////////////////////////////////////////////////////////////// Second Variant ////////////////////////////////
        //public override int Age 
        //{
        //    get 
        //    { 
        //        return base.Age; 
        //    }
        //    set
        //    {
        //        if(value > 15)
        //        {
        //            base.Age = 15;
        //        }
        //        else
        //        {
        //            base.Age = value;
        //        }
              
        //    }
        //}
        public Child(string name, int age) : base(name, age)
        {
          
        }
    }
}
