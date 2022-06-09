using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + thirdTime;
            int minutes = 0;
            int seconds = 0;
            if(totalTime>=120)
            {
                minutes = 2;
                seconds = totalTime - 120;
            }
            else if(totalTime>=60)
            {
                minutes = 1;
                seconds = totalTime - 60;
            }
            else
            {
                seconds = totalTime;
            }
            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }
}
