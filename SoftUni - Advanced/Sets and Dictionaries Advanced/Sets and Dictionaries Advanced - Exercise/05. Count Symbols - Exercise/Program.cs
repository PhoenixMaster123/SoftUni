using System;
using System.Collections.Generic;

namespace _05._Count_Symbols___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] arr = text.ToCharArray();
            SortedDictionary<char, int> map = new SortedDictionary<char, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if(!map.ContainsKey(arr[i]))
                {
                    map.Add(arr[i], 1);
                }
                else
                {
                    map[arr[i]]++;
                }
            }
            foreach (var symbols in map)
            {
                Console.WriteLine($"{symbols.Key}: {symbols.Value} time/s");
            }
        }
    }
}
