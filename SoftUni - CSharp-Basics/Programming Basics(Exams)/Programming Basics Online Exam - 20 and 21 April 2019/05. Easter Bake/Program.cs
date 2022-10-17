using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Easter_Bake
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterCake = int.Parse(Console.ReadLine());
            double totalSugar = 0;
            double totalFlour = 0;
            double paketsSugar = 0;
            double paketsFlour = 0;
            List<int> listSugar = new List<int>();
            List<int> listFlour = new List<int>();

            for (int i = 0; i < easterCake; i++)
            {
                int sugar = int.Parse(Console.ReadLine());
                int flour = int.Parse(Console.ReadLine());
                totalSugar += sugar;
                totalFlour += flour;
                listSugar.Add(sugar);
                listFlour.Add(flour);
            }
            paketsSugar = Math.Ceiling(totalSugar / 950);
            paketsFlour = Math.Ceiling(totalFlour / 750);
            int maxElementSugar = listSugar.Max();
            int maxElementFlour = listFlour.Max();
            Console.WriteLine($"Sugar: {paketsSugar}");
            Console.WriteLine($"Flour: {paketsFlour}");
            Console.WriteLine($"Max used flour is {maxElementFlour} grams, max used sugar is {maxElementSugar} grams.");
            
        }
    }
}
