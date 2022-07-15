using System;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Interface -> public side of our class
            // Interface -> define public visibility of our class 
            // Interface -> communication between classes
            // Using Interface -> abstracton level increasment
            // Abstraction in Business logic of the application -> Core class 
            // Work with interfaces without knowing the concrete implementation
            string name = Console.ReadLine(); 
            int age = int.Parse(Console.ReadLine()); 
            IPerson person = new Citizen(name, age); 
            Console.WriteLine(person.Name); 
            Console.WriteLine(person.Age);
        }
    }
}
