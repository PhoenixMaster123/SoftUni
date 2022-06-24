using System;
using System.Collections.Generic;

namespace _8.Car_Salesman
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfEngines = int.Parse(Console.ReadLine());
            var engines = new List<Engine>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                var info = Console.ReadLine().Split();
                engines.Add(CreateEngine(info));
            }

            var numberOfCars = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                var info = Console.ReadLine().Split();
                cars.Add(CreateCar(info, engines));
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        public static Car CreateCar(string[] info, List<Engine> engines)
        {
            var carModel = info[0];
            var engineModel = info[1];
            var engine = engines.Find(e => e.Model == engineModel);
            var car = new Car(carModel, engine);
            if (info.Length > 2)
            {
                var isDigit = int.TryParse(info[2], out int weight);
                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = info[2];
                }

                if (info.Length > 3)
                {
                    car.Color = info[3];
                }
            }
            return car;
        }

        public static Engine CreateEngine(string[] info)
        {
            var engineModel = info[0];
            var enginePower = int.Parse(info[1]);
            Engine engine = new Engine(engineModel, enginePower);
            if (info.Length > 2)
            {
                var isDigit = int.TryParse(info[2], out int displacement);
                if (isDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = info[2];
                }

                if (info.Length > 3)
                {
                    engine.Efficiency = info[3];
                }
            }

            return engine;
        }
    }
}
