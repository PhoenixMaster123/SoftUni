using System;
using System.Linq;

namespace PizzaCalories
{
    class StartUp
    {
        static void Main()
        {
            try
            {
                string[] order = Console.ReadLine().Split();
                Pizza pizza = new Pizza(order[1]);
                order = Console.ReadLine().Split();
                pizza.Dough = new Dough(order[1], order[2], double.Parse(order[3]));

                string command = Console.ReadLine();
                while (command != "END")
                {
                    order = command.Split();
                    pizza.AddTopping(new Topping(order[1], double.Parse(order[2])));
                    command = Console.ReadLine();
                }

                Console.WriteLine(pizza.Name + " - " + pizza.TotalCalories() + " Calories.");
            }
            catch (Exception anomaly)
            {
                Console.WriteLine(anomaly.Message);
            }
        }
    }
}
