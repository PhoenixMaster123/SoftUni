using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projections = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double premiere = 12.00;
            double normal = 7.50;
            double discount = 5.00;
            double price = 0;

            if (projections == "Premiere")
            {
                price = premiere * r * c;
            }
            else if (projections == "Normal")
            {
                price = normal * r * c;
            }
            else if (projections == "Discount") 
            {
                price = discount * r * c;
            }
            Console.WriteLine($"{price:F2} leva");

        }
    }
}
