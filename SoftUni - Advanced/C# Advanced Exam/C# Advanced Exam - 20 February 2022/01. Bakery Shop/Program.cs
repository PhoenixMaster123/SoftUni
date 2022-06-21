using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bakery_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] water = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] flour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Queue<double> queueWater = new Queue<double>(water);
            Stack<double> stackFlour = new Stack<double>(flour);

            Dictionary<string, int> shop = new Dictionary<string, int>
            {
                {"Croissant",0},
                {"Muffin",0},
                {"Baguette",0},
                {"Bagel",0}
              
            };
            int countFood = 0;

            while (queueWater.Count > 0 && stackFlour.Count > 0) 
            {
                double waterItem = queueWater.Peek();
                double flourItem = stackFlour.Peek();

                double sum = waterItem + flourItem;
                double waterPersent = (waterItem * 100) / sum;
                double flourPersent = (flourItem * 100) / sum;

                if(waterPersent == 50 && flourPersent == 50)
                {
                    shop["Croissant"]++;
                    queueWater.Dequeue();
                    stackFlour.Pop();
                    countFood++;
                }
                else if(waterPersent == 40 && flourPersent == 60)
                {
                    shop["Muffin"]++;
                    queueWater.Dequeue();
                    stackFlour.Pop();
                    countFood++;
                }
                else if (waterPersent == 30 && flourPersent == 70)
                {
                    shop["Baguette"]++;
                    queueWater.Dequeue();
                    stackFlour.Pop();
                    countFood++;
                }
                else if (waterPersent == 20 && flourPersent == 80)
                {
                    shop["Bagel"]++;
                    queueWater.Dequeue();
                    stackFlour.Pop();
                    countFood++;
                }
                else
                {
                    double currentFlower = stackFlour.Pop();
                    double currentWater = queueWater.Dequeue();
                    double flourReduced = currentFlower - currentWater;
                    shop["Croissant"]++;
                    stackFlour.Push(flourReduced);
                    
                }
            }
            foreach (var products in shop.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                if (products.Value > 0)
                {
                    Console.WriteLine($"{products.Key}: {products.Value}");
                }
            }
            if(queueWater.Count == 0)
            {
                Console.WriteLine("Water left: None");
            }
            else
            {
                Console.WriteLine("Water left: " + string.Join(", ", queueWater));
            }
            if (stackFlour.Count == 0)
            {
                Console.WriteLine("Flour left: None");
            }
            else
            {
                Console.WriteLine("Flour left: " + string.Join(", ", stackFlour));
            }
        }
    }
}
