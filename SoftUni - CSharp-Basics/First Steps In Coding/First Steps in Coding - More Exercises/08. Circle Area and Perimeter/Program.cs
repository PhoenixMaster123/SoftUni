using System;

namespace _08._Circle_Area_and_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r;

            Console.WriteLine("{0:0.00}", area);
            Console.WriteLine("{0:0.00}", perimeter);
        }
    }
}
