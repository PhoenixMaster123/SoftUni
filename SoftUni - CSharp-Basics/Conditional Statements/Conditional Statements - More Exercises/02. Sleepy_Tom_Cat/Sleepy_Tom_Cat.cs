using System;

namespace Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int restdays = int.Parse(Console.ReadLine());         
            int timeworkforplay = 365 - restdays;
            int time = timeworkforplay * 63 + restdays * 127;          
            if (30000 >= time)
            {

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{(30000 - time) / 60} hours and {(30000 - time) % 60} minutes less for play");               
            }

            else
            {
                Console.WriteLine($"Tom will run away");
                Console.WriteLine($"{(time - 30000) / 60} hours and {(time - 30000) % 60} minutes more for play");
            }
        }
    }
}
               
                

