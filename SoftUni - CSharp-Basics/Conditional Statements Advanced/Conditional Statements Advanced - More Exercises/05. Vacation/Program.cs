using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = "";
            string place = "";

            if (budget <= 1000)
            {
                place = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    budget = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    budget = budget * 0.45;
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                place = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    budget = budget * 0.80;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    budget = budget * 0.60;
                }
            }
            else if (budget > 3000) 
            {
                place = "Hotel";
                if (season == "Summer")
                {
                    location = "Alaska";
                    budget = budget * 0.90;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    budget = budget * 0.90;
                }
            }
            Console.WriteLine($"{location} - {place} - {budget:F2}");
        }
    }
}
