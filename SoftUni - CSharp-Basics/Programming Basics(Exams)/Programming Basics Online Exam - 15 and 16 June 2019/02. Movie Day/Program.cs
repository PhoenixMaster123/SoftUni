using System;

namespace _02._Movie_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForPhotos = int.Parse(Console.ReadLine());
            int scenes = int.Parse(Console.ReadLine());
            int range = int.Parse(Console.ReadLine());

            double preparationField = Math.Floor(timeForPhotos * 0.15);
            double timeForScenes = scenes * range;
            double allTime = preparationField + timeForScenes;

            if (timeForPhotos < allTime)
            {
                allTime -= timeForPhotos;
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Ceiling(allTime)} minutes.");
            }
            else
            {
                allTime -= timeForPhotos;
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Abs(allTime)} minutes left!");
            }
        }
    }
}
