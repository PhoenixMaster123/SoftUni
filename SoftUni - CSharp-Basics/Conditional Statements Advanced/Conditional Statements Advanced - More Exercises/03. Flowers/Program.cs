using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrizantemi = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int laleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string isHolyday = Console.ReadLine();

            double hrizantemiPrice = 0;
            double roziPrice = 0;
            double laletaPrice = 0;
            double totalPrice = 0;
            int discount = 0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    hrizantemiPrice = 2;
                    roziPrice = 4.1;
                    laletaPrice = 2.5;
                    break;
                case "Autumn":
                case "Winter":
                    hrizantemiPrice = 3.75;
                    roziPrice = 4.50;
                    laletaPrice = 4.15;
                    break;
            }
            totalPrice = hrizantemi * hrizantemiPrice + rozi * roziPrice + laleta * laletaPrice; ;
            if (isHolyday == "Y")
            {
                totalPrice *= 1.15;

            }
            if (season == "Spring" && laleta > 7)
            {
                discount += 5;
                totalPrice = totalPrice - ((totalPrice * discount) / 100);
            }
            if (season == "Winter" && rozi >= 10)
            {
                discount = 10;
                totalPrice = totalPrice - ((totalPrice * discount) / 100);
            }
            if (hrizantemi + rozi + laleta > 20)
            {
                discount = 20;
                totalPrice = totalPrice - ((totalPrice * discount) / 100);
            }

            Console.WriteLine("{0:f2}", totalPrice + 2);



        }
    }
}
