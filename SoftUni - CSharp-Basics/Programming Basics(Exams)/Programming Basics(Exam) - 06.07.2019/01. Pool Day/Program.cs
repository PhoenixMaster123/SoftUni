using System;

namespace _01._Pool_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double enterPrice = double.Parse(Console.ReadLine());
            double sunbed = double.Parse(Console.ReadLine());
            double umbrella = double.Parse(Console.ReadLine());

            double enter = people * enterPrice;
            double percentSunbed = Math.Ceiling(people * 0.75); 
            double price = percentSunbed * sunbed;
            double halfpeole = Math.Ceiling(people * 0.50);
            double priceUmbrella = halfpeole * umbrella;
            double total = enter + price + priceUmbrella;
            Console.WriteLine($"{total:F2} lv.");   
        }
    }
}
