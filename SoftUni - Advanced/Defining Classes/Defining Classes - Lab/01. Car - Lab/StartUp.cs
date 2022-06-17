using System;

namespace CarManufacturer
{  public class StartUp

{
    static void Main()
    {
        Car car = new Car();

        car.Make = "Mercedes";
        car.Model = "S-Class";
        car.Year = 2003;


       Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
    }

}

}

