using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Meal_Plan
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionaryPrices = new Dictionary<string, int>()
            {
                ["salad"] = 350,
                ["soup"] = 490,
                ["pasta"] = 680,
                ["steak"] = 790
            };

            Queue<string> meals = new Queue<string>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));

            List<int> caloriesTarget = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int countMeals = 0;

            while (meals.Count != 0 && caloriesTarget.Sum() > 0)
            {
                int currentCalories = caloriesTarget.Count - 1;

                caloriesTarget[currentCalories] -= dictionaryPrices[meals.Dequeue()];
                countMeals++;

                if (caloriesTarget[currentCalories] <= 0 && caloriesTarget.Sum() > 0)
                {
                    caloriesTarget[currentCalories - 1] += caloriesTarget[currentCalories];
                    caloriesTarget.RemoveAt(currentCalories);
                }
            }

            caloriesTarget.Reverse();
            if (meals.Count == 0)
            {
                Console.WriteLine($"John had {countMeals} meals.");
                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", caloriesTarget)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {countMeals} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", meals)}.");
            }

        }
    }
}