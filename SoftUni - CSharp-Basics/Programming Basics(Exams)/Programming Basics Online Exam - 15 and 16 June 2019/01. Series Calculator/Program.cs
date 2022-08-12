using System;

namespace _01._Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodes = int.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double ads = time * 0.20;
            double adsAndSerails = time + ads;
            double specialEpisodes = seasons * 10;

            double totalTime = adsAndSerails * episodes * seasons + specialEpisodes;
            Console.WriteLine($"Total time needed to watch the {serial} series is {totalTime} minutes.");
        }
    }
}
