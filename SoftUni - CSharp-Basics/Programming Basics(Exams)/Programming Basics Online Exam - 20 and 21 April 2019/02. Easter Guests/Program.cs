using System;

namespace _02._Easter_Guests
{
    class Program
    {
        static void Main(string[] args)
        {
            double guests = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double easterBread = Math.Ceiling(guests / 3);
            double eggs = guests * 2;
            double easterBreadPrice = easterBread * 4;
            double eggsPrice = eggs * 0.45;
            double total = easterBreadPrice + eggsPrice;
            if(total <= budget)
            {
                budget -= total;
                Console.WriteLine($"Lyubo bought {easterBread} Easter bread and {eggs} eggs.");
                Console.WriteLine($"He has {budget:F2} lv. left.");
            }
            else
            {
                total -= budget;
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {total:F2} lv. more.");
            }
          
        }
    }
}
