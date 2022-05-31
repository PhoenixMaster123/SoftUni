using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //List<string> symbols = Console.ReadLine().Split(' ').ToList();
            string[] words = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string,int> map = new Dictionary<string, int>();
            
            foreach (string word in words)
            {
                string lowerCase = word.ToLower();
                if (map.ContainsKey(lowerCase))
                {
                    map[lowerCase]++;
                }
                else
                {
                    map.Add(lowerCase, 1);
                }
            }
            ////////////////////////////////////////////// Variant 1 ////////////////////////////////////////
            //foreach (var item in map)
            //{
            //    if (item.Value % 2 != 0)
            //    {
            //        Console.Write($"{item.Key}");
            //    }
            //}
            ///////////////////////////////////////////// Variant 2 ////////////////////////////////////////
            string[] result = map.Where(item => item.Value % 2 != 0).Select(item=>item.Key).ToArray();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
