using System;

namespace Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnols = int.Parse(Console.ReadLine());
            int zumbuls = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int kaktus = int.Parse(Console.ReadLine());
            double present = double.Parse(Console.ReadLine());

            double magnolsprice = magnols * 3.25;
            double zumbulsprice = zumbuls * 4;
            double rosesprice = roses * 3.50;
            double kaktusprice = kaktus * 8;
            double allprice = magnolsprice + zumbulsprice + rosesprice + kaktusprice;
            double percent = 0.05 * allprice;
            double difference = allprice - percent;

            if (difference < present)
            {
                double geschenk = present - difference;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(geschenk)} leva.");
            }
            else
            {
                double something = difference - present;
                Console.WriteLine($"She is left with {Math.Floor(something)} leva.");
            }
        }
    }
}




