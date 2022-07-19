using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> map = new Dictionary<string, IBuyer>();

            int countPeople = int.Parse(Console.ReadLine());

            IBuyer customer = null;

            for (int i = 0; i < countPeople; i++)
            {
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = parts[0];
                if (parts.Length == 4)
                {
                    int age = int.Parse(parts[1]);
                    string id = parts[2];
                    string birthday = parts[3];

                    customer = new Citizen(name, age, id, birthday);

                }
                else if (parts.Length == 3)
                {

                    int age = int.Parse(parts[1]);
                    string group = parts[2];

                    customer = new Rebel(name, age, group);
                }
                map[name] = customer;
            }

            string customerNames = Console.ReadLine();

            while (customerNames != "End")
            {
                if (map.ContainsKey(customerNames))
                {
                    map[customerNames].BuyFood();
                }

                customerNames = Console.ReadLine();
            }

            int resultFood = map.Values.Sum(x => x.Food);

            Console.WriteLine(resultFood);
        }
    }
}
