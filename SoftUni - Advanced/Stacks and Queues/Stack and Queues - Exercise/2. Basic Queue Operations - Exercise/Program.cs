using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Basic_Queue_Operations___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int enqueue = array[0];
            int dequeue = array[1];
            int num = array[2];
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < enqueue; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < dequeue; i++)
            {
                queue.Dequeue();
            }
            if(queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if(queue.Contains(num))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
               
            
        }
    }
}
