using System;

namespace T2___Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesperday = int.Parse(Console.ReadLine());
            int walkperday = int.Parse(Console.ReadLine());
            double calories = int.Parse(Console.ReadLine());

            double alltime = walkperday * minutesperday;
            alltime *= 5;

            calories = calories * 0.5;
            if(alltime>=calories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {alltime}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {alltime}.");
            }
             


        }
    }
}
