using System;

namespace _05._Football_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string footballTeam = Console.ReadLine();
            int matches = int.Parse(Console.ReadLine());
            if (matches <= 0) 
            {
                Console.WriteLine($"{footballTeam} hasn't played any games during this season.");
                Environment.Exit(0);
            }
            int win = 0;
            int tie = 0;
            int lose = 0;
            int points = 0;
            double percent = 100;
            for (int i = 0; i < matches; i++)
            {
                string matchesResult = Console.ReadLine();
                if(matchesResult.Equals("W"))
                {
                    win++;
                    points += 3;
                }
                else if(matchesResult.Equals("D"))
                {
                    tie++;
                    points += 1;
                }
                else
                {
                    lose++;
                }
            }
            Console.WriteLine($"{footballTeam} has won {points} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {win}");
            Console.WriteLine($"## D: {tie}");
            Console.WriteLine($"## L: {lose}");
            double winRate = (percent / matches) * win;
            Console.WriteLine($"Win rate: {winRate:F2}%");
        }
    }
}
