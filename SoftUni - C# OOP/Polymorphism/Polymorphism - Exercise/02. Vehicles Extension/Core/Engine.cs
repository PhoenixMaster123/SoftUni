using P02.VehiclesExtension.Models;
using System;

namespace P02.VehiclesExtension.Core
{
    public class Engine : IEngine
    {
        public void Start()
        {

            string[] carValues = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Vehicle car = new Car(double.Parse(carValues[1]), double.Parse(carValues[2]), double.Parse(carValues[3]));

            string[] inputTruck = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Vehicle truck = new Truck(double.Parse(inputTruck[1]), double.Parse(inputTruck[2]), double.Parse(inputTruck[3]));

            string[] BusInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Vehicle bus = new Bus(double.Parse(BusInput[1]), double.Parse(BusInput[2]), double.Parse(BusInput[3]));

            int count = int.Parse(Console.ReadLine());

            for (int k = 0; k < count; k++)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Drive")
                {
                    if (command[1] == "Car")
                    {
                        Console.WriteLine(car.Drive(double.Parse(command[2])));
                    }
                    else if (command[1] == "Truck")
                    {
                        Console.WriteLine(truck.Drive(double.Parse(command[2])));
                    }
                    else if (command[1] == "Bus")
                    {
                        Console.WriteLine(bus.Drive(double.Parse(command[2])));
                    }
                }

                else if (command[0] == "Refuel")
                {
                    if (command[1] == "Car")
                    {
                        car.Refuel(double.Parse(command[2]));
                    }
                    else if (command[1] == "Truck")
                    {
                        truck.Refuel(double.Parse(command[2]));
                    }
                    else if (command[1] == "Bus")
                    {
                        bus.Refuel(double.Parse(command[2]));
                    }
                }

                else if (command[0] == "DriveEmpty")
                {
                    if (command[1] == "Car")
                    {
                        Console.WriteLine(car.DriveEmpty(double.Parse(command[2])));
                    }
                    else if (command[1] == "Truck")
                    {
                        Console.WriteLine(truck.DriveEmpty(double.Parse(command[2])));
                    }
                    else if (command[1] == "Bus")
                    {
                        Console.WriteLine(bus.DriveEmpty(double.Parse(command[2])));
                    }
                }

            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());

        }
    }
}

