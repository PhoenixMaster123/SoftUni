using System;

namespace _03._Film_Premiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string paketForMovie = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());
            double drink = 0;
            double popcorn = 0;
            double menu = 0;
            double total = 0;
            if (movie.Equals("John Wick"))
            {
                if(paketForMovie == "Drink")
                {
                    drink = 12;
                    total += drink * tickets;
                }
                else if(paketForMovie == "Popcorn")
                {
                    popcorn = 15;
                    total += popcorn * tickets;
                }
                else
                {
                    menu = 19;
                    total += menu * tickets;
                }
            }
            else if (movie.Equals("Star Wars"))
            {
                if (paketForMovie == "Drink")
                {
                    drink = 18;
                    total += drink * tickets;
                }
                else if (paketForMovie == "Popcorn")
                {
                    popcorn = 25;
                    total += popcorn * tickets;
                }
                else
                {
                    menu = 30;
                    total += menu * tickets;
                }
                if(tickets >= 4)
                {
                    total -= total * 0.30;
                }
            }
            else
            {
                if (paketForMovie == "Drink")
                {
                    drink = 9;
                    total += drink * tickets;
                }
                else if (paketForMovie == "Popcorn")
                {
                    popcorn = 11;
                    total += popcorn * tickets;
                }
                else
                {
                    menu = 14;
                    total += menu * tickets;
                }
                if(tickets == 2)
                {
                    total -= total * 0.15;
                }
            }
            Console.WriteLine($"Your bill is {total:F2} leva.");
        }
    }
}
