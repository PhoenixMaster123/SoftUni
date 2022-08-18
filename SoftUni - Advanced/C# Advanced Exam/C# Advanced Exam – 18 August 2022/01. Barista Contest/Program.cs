using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] quantitiesOfCoffee = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[] quantitiesOfMilk = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Queue<int> queueElements = new Queue<int>(quantitiesOfCoffee);
            Stack<int> stackElements = new Stack<int>(quantitiesOfMilk);

            Dictionary<string,int> dictionary = new Dictionary<string, int>()
            {
                {"Cortado",0},
                {"Espresso",0},
                {"Capuccino",0},
                {"Americano",0},
                {"Latte",0}
            };
            int currentCoffeeElement = queueElements.Peek();
            int currentMilkElement = stackElements.Peek();
            int sum = 0;
            while(queueElements.Count > 0 && queueElements.Count > 0)
            {
                sum = currentCoffeeElement + currentMilkElement;
                if(sum == 50)
                {
                    dictionary["Cortado"]++;
                    queueElements.Dequeue();
                    stackElements.Pop();
                    if (!stackElements.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentMilkElement = stackElements.Peek();
                    }
                    if (!queueElements.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentCoffeeElement = queueElements.Peek();
                    }
                }
                else if(sum == 75)
                {
                    dictionary["Espresso"]++;
                    queueElements.Dequeue();
                    stackElements.Pop();
                    if (!stackElements.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentMilkElement = stackElements.Peek();
                    }
                    if (!queueElements.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentCoffeeElement = queueElements.Peek();
                    }
                }
                else if (sum == 100)
                {
                    dictionary["Capuccino"]++;
                    queueElements.Dequeue();
                    stackElements.Pop();
                    if (!stackElements.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentMilkElement = stackElements.Peek();
                    }
                    if (!queueElements.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentCoffeeElement = queueElements.Peek();
                    }
                }
                else if (sum == 150)
                {
                    dictionary["Americano"]++;
                    queueElements.Dequeue();
                    stackElements.Pop();
                    if (!stackElements.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentMilkElement = stackElements.Peek();
                    }
                    if (!queueElements.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentCoffeeElement = queueElements.Peek();
                    }
                }
                else if (sum == 200)
                {
                    dictionary["Latte"]++;
                    queueElements.Dequeue();
                    stackElements.Pop();
                    if (!stackElements.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentMilkElement = stackElements.Peek();
                    }
                    if (!queueElements.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentCoffeeElement = queueElements.Peek();
                    }
                }
                else
                {
                    queueElements.Dequeue();
                    currentMilkElement -= 5;
                    stackElements.Pop();
                    stackElements.Push(currentMilkElement);
                    if(!stackElements.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentMilkElement = stackElements.Peek();
                    }
                    if (!queueElements.Any())
                    {
                        break;
                    }
                    else
                    {
                        currentCoffeeElement = queueElements.Peek();
                    }
                }
            }
            if(queueElements.Count == 0 && stackElements.Count == 0)
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
            }
            else
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");
            }
            if (queueElements.Count == 0)
            {
                Console.WriteLine("Coffee left: none");
            }
            else
            {
                Console.WriteLine($"Coffee left: " + string.Join(", ", queueElements));
            }
            if (stackElements.Count == 0)
            {
                Console.WriteLine("Milk left: none");
            }
            else
            {
                Console.WriteLine($"Milk left: " + string.Join(", ", stackElements));
            }
            foreach (var item in dictionary.OrderBy(x => x.Value).ThenByDescending(x=>x.Key))
            {
                if (item.Value > 0)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }

            }
        }
    }
}
