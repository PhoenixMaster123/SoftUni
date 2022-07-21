using _01._Vehicles.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Vehicles.Core
{
    public class Engine : IEngine
    {
            private readonly Vehicle car;
            private readonly Vehicle truck;

            public Engine(Vehicle car, Vehicle truck)
            {
                this.car = car;
                this.truck = truck;
            }

            public void Start()
            {
                int count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    string[] cmdArgs = Console.ReadLine().Split();
                    string actionType = cmdArgs[0];
                    string vehicle = cmdArgs[1];
                    double killometers = double.Parse(cmdArgs[2]);

                    if (actionType == "Drive")
                    {
                        if (vehicle == "Car")
                        {
                            Console.WriteLine(this.car.Drive(killometers));
                        }
                        else if (vehicle == "Truck")
                        {
                            Console.WriteLine(this.truck.Drive(killometers));
                        }
                    }
                    else if (actionType == "Refuel")
                    {
                        if (vehicle == "Car")
                        {
                            this.car.Refuel(killometers);
                        }
                        else if (vehicle == "Truck")
                        {
                            this.truck.Refuel(killometers);
                        }
                    }
                }

                Console.WriteLine(this.car);
                Console.WriteLine(this.truck);
              }
    }
}
    

