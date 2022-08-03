using System;

namespace _05._PC_Game_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countGames = int.Parse(Console.ReadLine());
            double hearthstone = 0;
            double fornite = 0;
            double overwatch = 0;
            double others = 0;
            double percent = 100;
            for (int i = 0; i < countGames; i++)
            {
                string games = Console.ReadLine();
                if(games == "Hearthstone")
                {
                    hearthstone++;
                }
                else if(games == "Fornite")
                {
                    fornite++;
                }
                else if (games == "Overwatch")
                {
                    overwatch++;
                }
                else
                {
                    others++;
                }
            }
            hearthstone = (percent / countGames) * hearthstone;
            fornite = (percent / countGames) * fornite;
            overwatch = (percent / countGames) * overwatch;
            others = (percent / countGames) * others;
            Console.WriteLine($"Hearthstone - {hearthstone:F2}%");
            Console.WriteLine($"Fornite - {fornite:F2}%");
            Console.WriteLine($"Overwatch - {overwatch:F2}%");
            Console.WriteLine($"Others - {others:F2}%");
        }
    }
}
