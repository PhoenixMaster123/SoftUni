using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person personOne = new Person(); /*the default constructor*/
            personOne.Name = "Peter";
            personOne.Age = 20;

            Person personTwo = new Person()
            {
                Name = "Kris",
                Age = 22
            }; /*the inline initialization*/
        }
    }
}
