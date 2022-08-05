using System;

namespace _01._Fruit_Market
{
    public class Program
    {
        static void Main(string[] args)
        {
            double strawberryPrice = double.Parse(Console.ReadLine());
            double kgbananas = double.Parse(Console.ReadLine());
            double kgorange = double.Parse(Console.ReadLine());
            double kgraspberries = double.Parse(Console.ReadLine());
            double kgstrawberries = double.Parse(Console.ReadLine());

            double rasberryPrice = strawberryPrice / 2;
            double orangePrice = rasberryPrice - rasberryPrice * 0.4;
            double bananasPrice = rasberryPrice - rasberryPrice * 0.8;

            double resultRasberry = kgraspberries * rasberryPrice;
            double resultOrange = kgorange * orangePrice;
            double resultBananas = kgbananas * bananasPrice;
            double resultStrawberries = strawberryPrice * kgstrawberries;

            double total = resultRasberry + resultOrange + resultBananas + resultStrawberries;
            Console.WriteLine($"{total:F2}");
        }
    }
}
