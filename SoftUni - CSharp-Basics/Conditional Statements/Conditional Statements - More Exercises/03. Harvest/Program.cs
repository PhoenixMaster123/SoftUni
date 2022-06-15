using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double allgrapes = x * y;
            double wine = 0.4 * allgrapes / 2.5;
            double remainding = wine - z;
            double perperson = remainding / workers;
            if (wine>=z)
            {
                
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters." );
                Console.WriteLine($"{Math.Ceiling(remainding)} liters left -> {Math.Ceiling(perperson)} liters per person.");
            }
            else
            {
                double wine2 = z - wine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wine2)} liters wine needed.");
            }
        }
    }
}
