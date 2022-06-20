using System;

namespace Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string clas = "";
            string car = "";

            if (budget <= 100)
            {
                clas = "Economy class";
                if (season == "Summer")
                {
                    car = "Cabrio";
                    budget = budget * 0.35;
                }
                else if (season == "Winter")
                {
                    car = "Jeep";
                    budget = budget * 0.65;
                }

            }
            else if (budget > 100 && budget <= 500)
            {
                clas = "Compact class";
                if (season == "Summer")
                {
                    car = "Cabrio";
                    budget = budget * 0.45;
                }
                else if (season == "Winter")
                {
                    car = "Jeep";
                    budget = budget * 0.80;
                }
            }
            else if (budget > 500) 
            {
                clas = "Luxury class";
                if (season=="Summer"||season=="Winter")
                {
                    car = "Jeep";
                    budget = budget * 0.90;
                }
            }
            Console.WriteLine($"{clas}");
            Console.WriteLine($"{car} - {budget:F2}");
        }
    }
}
