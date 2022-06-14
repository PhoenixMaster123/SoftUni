using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop___Lab
{
    internal class Program
    {
        static void Main()
        {
            var prices = new Dictionary<string, Dictionary<string, double>>();

          while(true)
            {
                string line = Console.ReadLine();
                if(line == "Revision")
                {
                    // Print
                   
                    foreach(var pr in prices.OrderBy(sh => sh.Key))
                    {
                        string shopName = pr.Key;
                            Console.WriteLine($"{shopName}->");
                        var pricesInShop = pr.Value;                   
                        foreach(var shopsAndPrice  in pricesInShop)
                        {
                            Console.WriteLine($"Product: {shopsAndPrice.Key}, Price: {shopsAndPrice.Value}");
                        }
                    }
                    break;
                }
                // Split
                string[] token = line.Split(", ");
                string shop = token[0];   
                string product = token[1];
                double price = double.Parse(token[2]);
                // Add product
                if (!prices.ContainsKey(shop))
                {
                     prices.Add(shop, new Dictionary<string, double>()); // ||
                    //prices[shop] = new Dictionary<string, double>();
                   
                }
                if (!prices[shop].ContainsKey(product))
                {
                    prices[shop].Add(product, price);
                }

            }
        }
    }
}
