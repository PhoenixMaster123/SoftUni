using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Songs_Queue___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();
          
            Queue<string> queue = new Queue<string>(songs);
            while(queue.Any())
            {
                string action = Console.ReadLine();
              
                if(action.Equals("Play"))
                {
                    queue.Dequeue();
                }
                else if(action.Contains("Add"))
                {
                    int index = action.IndexOf(' ');
                    string song = action.Substring(index + 1);
                    // other variant string song = action.Substring(4) - > example: "Add My Love" -> A(0) d(1) d(2) space(3) M(4) -> all after M
                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }  
                }
                else if(action == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
               
            }
            Console.WriteLine("No more songs!");
        }
    }
}
