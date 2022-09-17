using System;

namespace _05._Series
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int serialCount = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 0; i < serialCount; i++)
            {
                string serial = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                if(serial.Equals("Thrones"))
                {
                    price -= price * 0.50;
                }
                else if(serial.Equals("Lucifer"))
                {
                    price -= price * 0.40;
                }
                else if (serial.Equals("Protector"))
                {
                    price -= price * 0.30;
                }
                else if (serial.Equals("TotalDrama"))
                {
                    price -= price * 0.20;
                }
                else if (serial.Equals("Area"))
                {
                    price -= price * 0.10;
                }
                total += price;
            }
            if(budget < total)
            {
                total -= budget;
                Console.WriteLine($"You need {total:F2} lv. more to buy the series!");
            }
            else 
            {
                budget -= total;
                Console.WriteLine($"You bought all the series and left with {budget:F2} lv.");
            }
        }
    }
}
