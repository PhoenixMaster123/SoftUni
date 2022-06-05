using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fast_Food___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodForDay = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           
            Queue<int> queue = new Queue<int>(orders);
            Console.WriteLine(queue.Max());
            ////////////////////////////////////////////////////////////////////////// First Variant ////////////////////////////////////
            //while (queue.Count > 0)
            //{
            //    int currentOrder = queue.Peek();
            //    if (foodForDay >= currentOrder)
            //    {
            //        queue.Dequeue();
            //        foodForDay -= currentOrder;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            ///////////////////////////////////////////////////////////////////////// Second Variant ///////////////////////////////////////
            for (int i = 1; i <= orders.Length; i++)
            {
                if(foodForDay >= queue.Peek())
                {
                    foodForDay -= queue.Peek();
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

          
            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
              
            }
        }
    }
}