using System;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            double taxi = 0.70;
            double daytarif = 0.79;
            double nighttarif = 0.90;

            double bus = 0.09;
            double train = 0.06;

            if (n < 20 && time == "day")
            {
                double price = taxi + n * daytarif;
                Console.WriteLine($"{price:F2}");
            }
            else if (n < 20 && time == "night")
            {
                double price = taxi + n * nighttarif;
                Console.WriteLine($"{price:F2}");
            }
            else if (n >= 20 && n < 100)
            {
                double price = n * bus;
                Console.WriteLine($"{price:F2}");
            }
            else if(n>=100)
            {
                double price = n * train;
                Console.WriteLine($"{price:F2}");
            }

        }
    }
}
