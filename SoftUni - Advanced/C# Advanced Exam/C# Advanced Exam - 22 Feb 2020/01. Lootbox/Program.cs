using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Lootbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstLootBox = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondLootBox = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> queueFirstLootBox = new Queue<int>(firstLootBox);
            Stack<int> stackSecondLootBox = new Stack<int>(secondLootBox);
            List<int> result = new List<int>();
            
            int currentElementFirstBox = queueFirstLootBox.Peek();
            int currentElementSecondBox = stackSecondLootBox.Peek();

            int sum = currentElementFirstBox + currentElementSecondBox;
            while (queueFirstLootBox.Count > 0 && stackSecondLootBox.Count > 0)
            {
                if (sum % 2 == 0)
                {
                    result.Add(sum);
                    queueFirstLootBox.Dequeue();
                    stackSecondLootBox.Pop();

                    if (!stackSecondLootBox.Any())
                    {
                        Console.WriteLine("Second lootbox is empty");
                        break;
                    }
                    else
                    {                        
                        currentElementSecondBox = stackSecondLootBox.Peek();
                    }                   
                    if (!queueFirstLootBox.Any())
                    {
                        Console.WriteLine("First lootbox is empty");
                        break;

                    }
                    else
                    {                     
                        currentElementFirstBox = queueFirstLootBox.Peek();
                    }                                    
                   
                    sum = currentElementFirstBox + currentElementSecondBox;

                }
                else
                {
                        queueFirstLootBox.Enqueue(currentElementSecondBox);
                        stackSecondLootBox.Pop();
                        if (!stackSecondLootBox.Any())
                        {
                            Console.WriteLine("Second lootbox is empty");
                            break;
                        }
                        else
                        {
                           
                           currentElementSecondBox = stackSecondLootBox.Peek();
                        }
                       
                    
                    sum = currentElementFirstBox + currentElementSecondBox;

                }
            }
            int total = result.Sum();
            if(total > 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {total}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {total}");
            }
        }
    }
}
