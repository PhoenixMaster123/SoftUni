using System;

namespace _01._Movie_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int countTickets = int.Parse(Console.ReadLine());
            double ticketsPrice = double.Parse(Console.ReadLine());
            double percentCinema = int.Parse(Console.ReadLine());

            double pricetickets = countTickets * ticketsPrice;
            double allperiod = days * pricetickets;
            double percent = percentCinema / 100;

            double result = allperiod - allperiod * percent;
            Console.WriteLine($"The profit from the movie {name} is {result:F2} lv.");
        }
    }
}
