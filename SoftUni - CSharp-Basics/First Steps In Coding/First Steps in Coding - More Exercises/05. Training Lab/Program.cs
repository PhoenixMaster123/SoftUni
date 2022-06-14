using System;

namespace _05._Training_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());

            double w = double.Parse(Console.ReadLine());
            h *= 100;
            w *= 100;
            double h1 = Math.Floor(h / 120);
            double w1 = Math.Floor((w - 100) / 70);

            double result = (w1 * h1) - 3;
            Console.WriteLine(result);
        }
    }
}
