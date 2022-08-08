using System;

namespace _02._Mountain_Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double allSeconds = distanceInMeters * timeInSeconds;
            double addSeconds = (Math.Floor(distanceInMeters / 50)) * 30;
            double finalTime = allSeconds + addSeconds;
            if (finalTime >= recordInSeconds)
            {
                finalTime -= recordInSeconds;
                Console.WriteLine($"No! He was {finalTime:F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes! The new record is {finalTime:F2} seconds.");
            }

        }
    }
}
