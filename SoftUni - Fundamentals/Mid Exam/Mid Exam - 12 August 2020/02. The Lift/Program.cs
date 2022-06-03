using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            List<int> seats = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            // int[] seats = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int fullCapacity = 4;
            int result = peopleWaiting;
            //int normal = 0;
            for (int i = 0; i < seats.Count; i++)
            {
                // Standard Solution
                //int emptySeats = fullCapacity - seats[i];

                //if (emptySeats > 0)
                //{
                //    if (peopleWaiting < emptySeats)
                //    {
                //        seats[i] += peopleWaiting;
                //        peopleWaiting -= emptySeats;
                //    }
                //    else
                //    {
                //        peopleWaiting -= emptySeats;
                //        seats[i] += emptySeats;
                //    }
                //}
                //else
                //{
                //    continue;
                //}

                // Super Compact Variant
                int emptySeats = Math.Min(peopleWaiting, fullCapacity - seats[i]);
                seats[i] += emptySeats;
                peopleWaiting -= emptySeats;

                if (peopleWaiting <= 0)
                {
                    break;
                }
            }

            // If there are no more people and the lift have empty spots, you should print:
            if (peopleWaiting <= 0 && seats.Any(s => s < fullCapacity))
            {
                Console.WriteLine($"The lift has empty spots!");
                //Console.WriteLine(string.Join(" ", seats));
            }
            // If there are still people in the queue and no more available space, you should print:
            else if (peopleWaiting > 0 && seats.All(s => s == 4))
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                //Console.WriteLine(string.Join(" ", seats));
            }

            // If the lift is full and there are no more people in the queue, you should print only the wagons separated by " "
            Console.WriteLine(string.Join(" ", seats));
        }
    }
}