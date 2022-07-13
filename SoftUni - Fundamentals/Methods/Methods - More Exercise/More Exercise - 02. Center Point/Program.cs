using System;

namespace More_Exercise_02._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            FindXYCenter(x1, x2, y1, y2);
        }
        static void FindXYCenter(double x1, double x2, double y1, double y2)
        {
            double firstCoordinates = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
            double secondCoordinates = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

            if (firstCoordinates < secondCoordinates)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
