using System;

namespace Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double liturs = double.Parse(Console.ReadLine());

            if (fuel != "Gas" && fuel != "Diesel" && fuel != "Gasoline")
            {
                Console.WriteLine("Invalid fuel!");
            }
            

            else if (liturs >= 25 ) //&& fuel == "Gas" && fuel == "Diesel" && fuel == "Gasoline"
            {
                 Console.WriteLine($"You have enough {fuel.ToLower()}.");
                //Console.WriteLine("You have enough {0}", fuel.ToLower());
            }
            else if (liturs < 25)
            {
               Console.WriteLine($"Fill your tank with {fuel.ToLower()}!"); ;
            }
            
            
        }
    }
}

