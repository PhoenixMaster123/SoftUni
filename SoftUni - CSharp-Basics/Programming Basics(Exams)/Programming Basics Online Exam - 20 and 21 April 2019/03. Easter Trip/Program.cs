using System;

namespace _03._Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string dates = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            int total = 0;
            if(country == "France")
            {
                if(dates == "21-23")
                {
                    total = 30 * nights;
                }
                else if(dates == "24-27")
                {
                    total = 35 * nights;
                }
                else
                {
                    total = 40 * nights;
                }
            }
            else if(country == "Italy")
            {
                if (dates == "21-23")
                {
                    total = 28 * nights;
                }
                else if (dates == "24-27")
                {
                    total = 32 * nights;
                }
                else
                {
                    total = 39 * nights;
                }
            }
            else
            {
                if (dates == "21-23")
                {
                    total = 32 * nights;
                }
                else if (dates == "24-27")
                {
                    total = 37 * nights;
                }
                else
                {
                    total = 43 * nights;
                }
            }
            Console.WriteLine($"Easter trip to {country} : {total:F2} leva.");
        }
    }
}
