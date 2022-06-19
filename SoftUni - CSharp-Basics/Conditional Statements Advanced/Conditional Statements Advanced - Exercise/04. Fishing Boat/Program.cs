using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double price = 0;

            double springships = 3000;
            double summerandautumn = 4200;
            double winterships = 2600;
           


            switch (season)
            {
                case "Winter":
                    price = winterships;
                    break;
                case "Spring":
                    price = springships;
                    break;
                case "Summer":                   
                case "Autumn":
                    price = summerandautumn;
                    break;

            }
            if (count <= 6)
            {
                price -= price * 0.10;
            }
            else if (count >= 7 && count <= 11)
            {
                price -= price * 0.15;
            }
            else
            {
                price -= price * 0.25;
            }
            if (count % 2 == 0 && season != "Autumn")
            {
                price -= price * 0.05;
            }

            if(budget>=price)
            {
                double moneyLeft = budget - price;
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }
            else
            {
                double moneyneeded = price - budget;
                Console.WriteLine($"Not enough money! You need {moneyneeded:F2} leva.");
            }
        }
    }
}
