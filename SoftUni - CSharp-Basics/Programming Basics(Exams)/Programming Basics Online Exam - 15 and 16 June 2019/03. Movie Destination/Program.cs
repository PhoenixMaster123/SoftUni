using System;

namespace _03._Movie_Destination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double total = 0;
            if(destination == "Dubai")
            {
                if(season == "Winter")
                {
                    double price = 45000;
                    total = price * days;
                }
                else
                {
                    double price = 40000;
                    total = price * days;
                }
                total -= total * 0.30;
            }
            else if (destination == "Sofia")
            {
                if (season == "Winter")
                {
                    double price = 17000;
                    total = price * days;
                }
                else
                {
                    double price = 12500;
                    total = price * days;
                }
                total += total * 0.25;
            }
            else
            {
                if (season == "Winter")
                {
                    double price = 24000;
                    total = price * days;
                }
                else
                {
                    double price = 20250;
                    total = price * days;
                }
                
            }
            if(total > movieBudget) 
            {
                total -= movieBudget;
                Console.WriteLine($"The director needs {total:F2} leva more!");
                
            }
            else
            {
                movieBudget -= total;
                Console.WriteLine($"The budget for the movie is enough! We have {movieBudget:F2} leva left!");
            }
        }
    }
}
