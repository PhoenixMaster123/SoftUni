using System;

namespace _02._Family_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfNights = int.Parse(Console.ReadLine());
            double nightPerDay = double.Parse(Console.ReadLine());
            double percentOfAdditionalCosts = int.Parse(Console.ReadLine());

            if (numberOfNights > 7)
            {
                nightPerDay -= nightPerDay * 0.05;
            }

            double allsum = nightPerDay * numberOfNights;
            double otherCosts = budget - budget * (percentOfAdditionalCosts / 100);

            otherCosts = budget - otherCosts;
            double result = allsum + otherCosts;

            if (budget >= result)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - result:F2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{result - budget:F2} leva needed.");
            }
        }
    }
}
