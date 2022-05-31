using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> totalPrice = new Dictionary<string, double>();
            Dictionary<string, int> totalQuantity = new Dictionary<string, int>();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string product = input[0];

                if (totalPrice.ContainsKey(product) && product != "buy")
                {
                    double price = double.Parse(input[1]);
                    int quantity = int.Parse(input[2]);

                    totalPrice[product] = price;
                    totalQuantity[product] += quantity;
                }

                else if (product != "buy")
                {
                    double price = double.Parse(input[1]);
                    int quantity = int.Parse(input[2]);

                    totalQuantity.Add(product, quantity);
                    totalPrice.Add(product, price);
                }

                else if (product == "buy")
                {
                    foreach (var p in totalQuantity)
                    {
                        string Product = p.Key;
                        int quantity = p.Value;
                        double price = totalPrice[Product];
                        double results = quantity * price;
                        Console.WriteLine($"{Product} -> {results:f2}");
                    }
                    break;
                }

            }
        }
    }
}
