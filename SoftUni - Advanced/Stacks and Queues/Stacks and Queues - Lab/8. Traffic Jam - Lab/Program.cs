using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            Queue<string> queue = new Queue<string>();
            while(true)
            {
                string command = Console.ReadLine();
                if(command=="green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if(queue.Count>0)
                        {
                            string car = queue.Dequeue();
                            Console.WriteLine($"{car} passed!");
                            count++;
                        }
                    }
                }
                else if(command=="end")
                {
                    Console.WriteLine($"{count} cars passed the crossroads.");
                    break;
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
        }
    }
}
