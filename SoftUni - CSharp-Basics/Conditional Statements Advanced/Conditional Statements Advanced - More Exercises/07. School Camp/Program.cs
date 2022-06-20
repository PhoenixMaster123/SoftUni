using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double price = 0;
            string sport = "";

            if (group == "boys" && season == "Winter" || group == "girls" && season == "Winter")
            {
                price = students * nights * 9.60;
                if (group == "girls")
                {
                    sport = "Gymnastics";
                }
                else
                {
                    sport = "Judo";
                }
            }
            else if (group == "mixed" && season == "Winter")
            {
                price = students * nights * 10;
                if (group == "mixed")
                {
                    sport = "Ski";
                }

            }

            else if (group == "boys" && season == "Spring" || group == "girls" && season == "Spring")
            {
                price = students * nights * 7.20;
                if (group == "girls")
                {
                    sport = "Athletics";
                }
                else
                {
                    sport = "Tennis";
                }
            }
            else if (group == "mixed" && season == "Spring")
            {
                price = students * nights * 9.50;
                if (group == "mixed")
                {
                    sport = "Cycling";
                }
            }

            else if (group == "boys" && season == "Summer" || group == "girls" && season == "Summer") 
            {
                price = students * nights * 15;
                if (group == "girls")
                {
                    sport = "Volleyball";
                }
                else
                {
                    sport = "Football";
                }
            }
            else if (group == "mixed" && season == "Summer")
            {
                price = students * nights * 20;
                if (group == "mixed")
                {
                    sport = "Swimming";
                }
            }
            if (students >= 50)
            {
                price = price - price * 0.50;
            }
            else if (students >= 20 && students < 50)
            {
                price = price - price * 0.15;
            }
            else if (students >= 10 && students < 20)
            {
                price = price - price * 0.05;
            }
            Console.WriteLine($"{sport} {price:F2} lv.");

        }
    }
}
