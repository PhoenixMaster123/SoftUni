using System;

namespace T5___Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string equipment = "";
            int count = 0;
            double money = 0;
            while(true)
            {
                equipment = Console.ReadLine();
                if(equipment=="Stop")
                {
                    break;
                }
                double price = double.Parse(Console.ReadLine());             
                count++;
                if (count % 3 == 0)
                {
                    price /= 2;
                }
                money += price;
                budget -= price;
                if(budget<0)
                {
                    break;
                }
                

            }

            if (budget >= 0)
            {
                Console.WriteLine($"You bought {count} products for {money:f2} leva.");
            }
            else
            {
                Console.WriteLine("You don't have enough money!");
                Console.WriteLine($"You need {Math.Abs(budget):f2} leva!");
            }
        }
    }
}
