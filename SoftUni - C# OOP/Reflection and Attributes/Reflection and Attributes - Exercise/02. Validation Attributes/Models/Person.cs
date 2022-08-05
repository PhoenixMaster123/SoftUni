using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Models
{
    using Utilities;
    using ValidationAttributes.Utilities.Attributes;

    public class Person
    {
        private const int minValue = 12;
        private const int maxValue = 90;
        [MyRequired]
       public string FullName { get; set; }
        [MyRange(minValue, maxValue)]
        public int Age { get; set; }
        public Person(string fullName, int age)
        {
            this.FullName = fullName;
            this.Age = age;
        }
    }
}
