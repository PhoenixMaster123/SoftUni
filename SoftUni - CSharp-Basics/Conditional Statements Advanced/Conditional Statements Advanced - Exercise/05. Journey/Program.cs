using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            double price = 0;
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    price = budget * 0.30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {price:F2}");
                }
                else
                {
                    price = budget * 0.70;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {price:F2}");
                }
            }
            else if (budget > 100 && budget <= 1000) 
            {
                if (season == "summer") 
                {
                    price = budget * 0.40;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {price:F2}");
                }
                else
                {
                    price = budget * 0.80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {price:F2}");
                }
            }
            else
            {
                price = budget * 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {price:F2}");
            }
        }
    }
}
