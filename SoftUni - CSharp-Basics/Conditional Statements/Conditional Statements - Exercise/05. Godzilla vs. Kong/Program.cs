using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double cloats = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double pricecloats = statists * cloats;
            //double allprice = decor + pricecloats;
            //double result = budget - allprice;
            if(statists>150)
            {
                pricecloats *= 0.90;
            }
            double allprice = decor + pricecloats;
            //double result = budget - allprice;

            if (allprice>budget)
            {
                double result = budget - allprice;
                Console.WriteLine($"Not enough money!\nWingard needs { Math.Abs(result):F2} leva more.");
            }
            
            else
            {
                double result = budget - allprice;
                Console.WriteLine($"Action!\nWingard starts filming with {result:F2} leva left.");
            }
        }
    }
}
