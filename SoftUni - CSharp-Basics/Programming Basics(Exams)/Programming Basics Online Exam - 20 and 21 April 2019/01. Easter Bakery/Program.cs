using System;

namespace _01._Easter_Bakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double flourPrice = double.Parse(Console.ReadLine());
            double flourAmount = double.Parse(Console.ReadLine());
            double sugarAmount = double.Parse(Console.ReadLine());
            int eggsPeel = int.Parse(Console.ReadLine());
            int yeastAmount = int.Parse(Console.ReadLine());

            double sugarPrice = flourPrice * 0.75;
            double oneEggsPeel = flourPrice * 1.1;
            double yeastPrice = sugarPrice * 0.2;

            double flourTotal = flourPrice * flourAmount;
            double sugarTotal = sugarPrice * sugarAmount;
            double eggsTotal = eggsPeel * oneEggsPeel;
            double yeastTotal = yeastPrice * yeastAmount;

            Console.WriteLine($"{flourTotal + sugarTotal + eggsTotal + yeastTotal:F2}");
        }
    }
}
