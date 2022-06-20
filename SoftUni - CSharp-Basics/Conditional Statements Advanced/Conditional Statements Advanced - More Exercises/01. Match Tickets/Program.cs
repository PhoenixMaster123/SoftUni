using System;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string clasa = Console.ReadLine();
            int group = int.Parse(Console.ReadLine());

            double price = 0;
            double difference = 0;

            if (group >= 1 && group <= 4)
            {
                price = budget - budget * 0.75;
            }
            else if (group >= 5 && group <= 9)
            {
                price = budget - budget * 0.60;
            }
            else if (group >= 10 && group <= 24)
            {
                price = budget - budget * 0.50;
            }
            else if (group >= 25 && group <= 49)
            {
                price = budget - budget * 0.40;
            }
            else if (group >= 50) 
            {
                price = budget - budget* 0.25;
            }
            if (clasa == "VIP") 
            {
                 difference = 499.99 * group;
               
            }
            else if(clasa=="Normal")
            {
                 difference = 249.99 * group;
            }
            if (difference > price)
            {
                double result = difference - price;
                //result = budget - result;
                Console.WriteLine($"Not enough money! You need {result:F2} leva.");
             
            }
            if (price > difference) 
            {
                double result = price - difference;
                //result = budget - result;
                Console.WriteLine($"Yes! You have {result:F2} leva left.");
            }

        }
    }
}
