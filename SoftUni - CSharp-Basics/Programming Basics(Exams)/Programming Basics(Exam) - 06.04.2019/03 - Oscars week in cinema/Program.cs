using System;

namespace T3___Oscars_week_in_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string typesaal = Console.ReadLine();
            int bilets = int.Parse(Console.ReadLine());
            double money = 0;
            if (typesaal == "normal")
            {
                if (movie == "A Star Is Born")
                {
                    money = bilets * 7.50;
                }
                else if(movie == "Bohemian Rhapsody")
                {
                    money = bilets * 7.35;
                }
                else if(movie == "Green Book")
                {
                    money = bilets * 8.15;
                }
                else
                {
                    money = bilets * 8.75;
                }
            }
            else if(typesaal== "luxury")
            {
                if (movie == "A Star Is Born")
                {
                    money = bilets * 10.50;
                }
                else if (movie == "Bohemian Rhapsody")
                {
                    money = bilets * 9.45;
                }
                else if (movie == "Green Book")
                {
                    money = bilets * 10.25;
                }
                else
                {
                    money = bilets * 11.55;
                }
            }
            else
            {
                if (movie == "A Star Is Born")
                {
                    money = bilets * 13.50;
                }
                else if (movie == "Bohemian Rhapsody")
                {
                    money = bilets * 12.75;
                }
                else if (movie == "Green Book")
                {
                    money = bilets * 13.25;
                }
                else
                {
                    money = bilets * 13.95;
                }
            }
            Console.WriteLine($"{movie} -> {money:F2} lv.");
        }
    }
}
