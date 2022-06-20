using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());
            double price = 0;

            if (km <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    km = km * 0.75;
                    price = km * 4 * 0.90;

                }
                else if (season == "Summer")
                {
                    km = km * 0.90;
                    price = km * 4  * 0.90;



                }
                else if (season == "Winter")
                {
                    km = km * 1.05;
                    price = km * 4 * 0.90;
                }

            }
            else if (km > 5000 && km <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    km = km * 0.95;
                    price = km * 4 * 0.90;
                }
                else if (season == "Summer")
                {
                    km = km * 1.10;
                    price = km * 4 * 0.90;

                }
                else if (season == "Winter")
                {
                    km = km * 1.25;
                    price = km * 4 * 0.90;
                }

            }
            else if (km > 10000 && km <= 20000) 
            {
                if (season == "Spring" || season == "Autumn" || season == "Summer" || season == "Winter") 
                {
                    km = km * 1.45;
                    price = km * 4 * 0.90;
                }            

            }
            Console.WriteLine($"{price:F2}");

        }
    }
}
