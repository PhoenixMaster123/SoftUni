using System;
using System.Linq;

namespace _02._Sum_Numbers___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int result = numbers.Sum();
            int count = numbers.Length;
            Console.WriteLine(count);
            Console.WriteLine(result);
        }
    }
}
