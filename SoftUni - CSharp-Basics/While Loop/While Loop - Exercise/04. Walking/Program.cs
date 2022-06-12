using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int  total = 0;
            while (total < 10000)
            {
                string steps = Console.ReadLine();
                if (steps == "Going home")
                {
                    int stepsLeft = int.Parse(Console.ReadLine());
                    total += stepsLeft;
                    break;
                }
                int currentsteps = int.Parse(steps);
                total += currentsteps;                
            }
            if (total >= 10000)
            {
                Console.WriteLine($"Goal reached! Good job!");
                int goal = total - 10000;
                Console.WriteLine($"{goal} steps over the goal!");
            }
            else
            {
                int diff = 10000 - total;
                Console.WriteLine($"{diff} more steps to reach goal.");
            }

        }
    }
}
