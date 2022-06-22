using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Car c = new Car();
            Console.WriteLine(c.WhoAmI());
            Console.WriteLine();

            Car shkoda = new Car("Shkoda", "Felicia", 1999);
            Console.WriteLine(shkoda.WhoAmI());
            Console.WriteLine();

            Car car = new Car();
            car.Make = "BMW";
            car.Model = "X6";
            car.Year = 2022;
            car.FuelQuantity = 50;
            car.FuelConsumption = 0.07;

            Car anotherCar = new Car()
            {
                Make = "Toyota",
                Model = "Avensis",
                Year = 2018,
                FuelQuantity = 40,
                FuelConsumption = 0.08
            };
            Console.WriteLine(anotherCar.WhoAmI());
            Console.WriteLine();

            Console.WriteLine(car.WhoAmI());
            Console.WriteLine();

            car.Drive(700);
            Console.WriteLine(car.WhoAmI());
            Console.WriteLine();

            car.Drive(50);
            Console.WriteLine(car.WhoAmI());
            Console.WriteLine();
        }
    }
}
