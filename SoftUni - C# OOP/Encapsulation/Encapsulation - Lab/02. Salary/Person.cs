﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Person
    {         
        public string FirstName 
        {   
            get
            {
                return this.firstName;
            }
            private set
            {           
                this.firstName = value;
            } 
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {             
                this.lastName = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                this.age = value;
            }
        }
        public decimal Salary
        {
            get
            {
                return this.salaly;
            }
            private set
            {
                this.salaly = value;
            }
        }


        public Person(string firstName, string lastName, int age,decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }
     
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.Salary += this.Salary * percentage / 100;
            }
            else
            {
                this.Salary += this.Salary * percentage / 200;
            }
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:F2} leva.";
        }

    }
}
