using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    internal class Program
    {
        public static int DiCtionary { get; private set; }

        static void Main(string[] args)
        {
            const int dippingSauce = 150;
            const int greenSalad = 250;
            const int chocolateCake = 300;
            const int lobster = 400;

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] freshnessLevel = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            SortedDictionary<string, int> meals = new SortedDictionary<string, int>()
            {
                {"Dipping sauce",0},
                {"Green salad",0},
                {"Chocolate cake",0},
                {"Lobster",0}
            };
            Queue<int> queueIngredient = new Queue<int>(numbers);
            Stack<int> stackFreshnessLevel = new Stack<int>(freshnessLevel);

            while (queueIngredient.Count > 0 && stackFreshnessLevel.Count > 0)
            {
                int currentIngredient = queueIngredient.Peek();
                int currentFreshnessLevel = stackFreshnessLevel.Peek();
                int multiply = currentIngredient * currentFreshnessLevel;


                if(currentIngredient == 0)
                {
                    queueIngredient.Dequeue();
                    continue;
                }

                if (multiply.Equals(dippingSauce))
                {
                    meals["Dipping sauce"]++;
                    queueIngredient.Dequeue();
                    stackFreshnessLevel.Pop();
                }
                else if (multiply.Equals(greenSalad))
                {
                    meals["Green salad"]++;
                    queueIngredient.Dequeue();
                    stackFreshnessLevel.Pop();
                }
                else if (multiply.Equals(chocolateCake))
                {
                    meals["Chocolate cake"]++;
                    queueIngredient.Dequeue();
                    stackFreshnessLevel.Pop();
                }
                else if (multiply.Equals(lobster))
                {
                    meals["Lobster"]++;
                    queueIngredient.Dequeue();
                    stackFreshnessLevel.Pop();
                }               
                else
                {
                    stackFreshnessLevel.Pop();
                    currentIngredient += 5;
                    queueIngredient.Dequeue();
                    queueIngredient.Enqueue(currentIngredient);


                }
            }
            if(meals["Dipping sauce"] > 0 && meals["Green salad"] > 0 && meals["Chocolate cake"] > 0 && meals["Lobster"] > 0)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }
            if(queueIngredient.Any())
            {
                Console.WriteLine($"Ingredients left: {queueIngredient.Sum()}");
            }
            foreach(var meal in meals)
            {
                if(meal.Value > 0)
                {
                    Console.WriteLine($" # {meal.Key} --> {meal.Value}");
                }
            }
        }
    }
}
