using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Cooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] liquids = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] ingredients = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> queueLiquid = new Queue<int>(liquids);
            Stack<int> stackIngredients = new Stack<int>(ingredients);

            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>()
            {
                {"Bread",0},
                {"Cake",0},
                {"Pastry",0},
                {"Fruit Pie",0}
            };
            int currentLiquid = queueLiquid.Peek();
            int currentIngredient = stackIngredients.Peek();
            int sum = 0;
            while (queueLiquid.Count > 0 && stackIngredients.Count > 0)
            {
                sum = currentLiquid + currentIngredient;
                if(sum == 25)
                {
                    dictionary["Bread"]++;
                    queueLiquid.Dequeue();
                    stackIngredients.Pop();
                    if(!queueLiquid.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentLiquid = queueLiquid.Peek();
                    }
                    if(!stackIngredients.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentIngredient = stackIngredients.Peek();
                    }
                }
                else if(sum == 50)
                {
                    dictionary["Cake"]++;
                    queueLiquid.Dequeue();
                    stackIngredients.Pop();
                    if (!queueLiquid.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentLiquid = queueLiquid.Peek();
                    }
                    if (!stackIngredients.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentIngredient = stackIngredients.Peek();
                    }
                }
                else if (sum == 75)
                {
                    dictionary["Pastry"]++;
                    queueLiquid.Dequeue();
                    stackIngredients.Pop();
                    if (!queueLiquid.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentLiquid = queueLiquid.Peek();
                    }
                    if (!stackIngredients.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentIngredient = stackIngredients.Peek();
                    }
                }
                else if (sum == 100)
                {
                    dictionary["Fruit Pie"]++;
                    queueLiquid.Dequeue();
                    stackIngredients.Pop();
                    if (!queueLiquid.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentLiquid = queueLiquid.Peek();
                    }
                    if (!stackIngredients.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentIngredient = stackIngredients.Peek();
                    }
                }
                else
                {                   
                    queueLiquid.Dequeue();
                    currentIngredient += 3;
                    stackIngredients.Pop();
                    stackIngredients.Push(currentIngredient);
                    if (!queueLiquid.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentLiquid = queueLiquid.Peek();
                    }
                }
            }
            
            if (dictionary["Bread"] >= 1 && dictionary["Cake"] >= 1 && dictionary["Pastry"] >= 1 && dictionary["Fruit Pie"] >= 1)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
            if(queueLiquid.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine($"Liquids left: " + string.Join(", ", queueLiquid));
            }
            if (stackIngredients.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine($"Ingredients left: " + string.Join(", ", stackIngredients));
            }
            foreach(var item in dictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
