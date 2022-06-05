using System;
using System.Collections.Generic;

namespace _7._Hot_Potato___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(names); 
          
            while(queue.Count > 1)
            {
                for (int i = 1; i <= n-1; i++)
                {
                    string player = queue.Dequeue();
                    queue.Enqueue(player);
                }
                string lostPlayer = queue.Dequeue();
                Console.WriteLine($"Removed {lostPlayer}");
            }
            string lastPlayer = queue.Dequeue();
            Console.WriteLine($"Last is {lastPlayer}");
        }
    }
}
