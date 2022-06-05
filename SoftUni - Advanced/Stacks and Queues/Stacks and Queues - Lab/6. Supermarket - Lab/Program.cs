using System;
using System.Collections.Generic;
using System.Linq;

namespace _6_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            string input = null;

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    while (names.Any())
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                }
                else
                {
                    names.Enqueue(input);
                }
            }

            Console.WriteLine(names.Count + " people remaining.");
        }
    }
}

