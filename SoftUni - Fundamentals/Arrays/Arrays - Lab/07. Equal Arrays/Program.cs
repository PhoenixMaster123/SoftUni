using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] items = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;         
            //bool flag = false;
            for ( int i = 0; i < items.Length; i++)
            {
                sum += items[i];
                if (items[i] != numbers[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                   // flag = true;
                    return;
                   // break;
                    
                }   
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
            //if (!flag)
            //{
            //    Console.WriteLine($"Arrays are identical. Sum: {sum}");
            //}  

        }
    }
}
