using System;

namespace Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int episodes = int.Parse(Console.ReadLine());
            double timebreak = int.Parse(Console.ReadLine());

            double timeforlunch = timebreak / 8;
            double timeforrest = timebreak / 4;
            double timeleft = timebreak - (timeforlunch + timeforrest);
            double neededtime = Math.Abs(episodes - timeleft);
            Console.WriteLine(timeleft>=episodes? $"You have enough time to watch {serial} and left with {Math.Ceiling(neededtime)} minutes free time.": 
            $"You don't have enough time to watch {serial}, you need {Math.Ceiling(neededtime)} more minutes.");

            /* (timeleft<=episodes)
            {
                Console.WriteLine($"You have enough time to watch {serial} and left with {timeleft:F2} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {Math.Abs(timeleft):F2} more minutes.");
            }*/
        }
    }
}
