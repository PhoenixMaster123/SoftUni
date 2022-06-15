using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogfood = double.Parse(Console.ReadLine());
            double catfood = double.Parse(Console.ReadLine());
            double turtlefood = double.Parse(Console.ReadLine());

            double alldogfood = days * dogfood;
            double allcatfood = days * catfood;
            double allturtlefood = (days * turtlefood) / 1000;

            double allfood = alldogfood + allcatfood + allturtlefood;
            if (allfood <= food)
            {
                double foodremains = food - allfood;
                Console.WriteLine($"{Math.Floor(foodremains)} kilos of food left.");
            }
            else if(allfood>=food)
            {
                double foodneeded = allfood - food;
                Console.WriteLine($"{Math.Ceiling(foodneeded)} more kilos of food are needed.");
            }
        }
    }
}
