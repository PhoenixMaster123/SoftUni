using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           var countNumbers = new Dictionary<double, int>();
            foreach (int num in numbers)
            {
                if(countNumbers.ContainsKey(num))
                {
                    countNumbers[num]++;
                }
                else
                {
                    countNumbers[num] = 1;
                }
            }
            foreach(var pair in countNumbers)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }
           
        }
    }
}
