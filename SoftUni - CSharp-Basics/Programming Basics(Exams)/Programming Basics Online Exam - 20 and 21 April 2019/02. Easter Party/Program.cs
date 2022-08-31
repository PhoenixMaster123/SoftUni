using System;

namespace _02._Easter_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double envelope = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            if(guests >= 10 && guests <= 15)
            {
                envelope -= envelope * 0.15;
            }
            else if(guests > 15 && guests <= 20)
            {
                envelope -= envelope * 0.20;
            }
            else if(guests > 20)
            {
                envelope -= envelope * 0.25;
            }          
            double cakePrice = budget * 0.10;
            double total = guests * envelope + cakePrice;
            if(total > budget)
            {
                total -= budget;
                Console.WriteLine($"No party! {total:F2} leva needed.");
            }
            else
            {
                total -= budget;
                Console.WriteLine($"It is party time! {Math.Abs(total):F2} leva left.");
            }

        }
    }
}
