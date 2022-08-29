using System;

namespace _01._Easter_Lunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cozunaci = int.Parse(Console.ReadLine());
            int eggs = int.Parse(Console.ReadLine());
            int kgCookies = int.Parse(Console.ReadLine());

            double cozunaciPrice = cozunaci * 3.20;
            double eggPrice = eggs * 4.35;
            double cookiesPrice = kgCookies * 5.40;
            double paintEggs = eggs * 12 * 0.15;
            double total = cozunaciPrice + eggPrice + cookiesPrice + paintEggs;
            Console.WriteLine($"{total:F2}");
        }
    }
}
