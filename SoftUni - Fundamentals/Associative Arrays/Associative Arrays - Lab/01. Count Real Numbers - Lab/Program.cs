using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /////////////////////////////////////////////////////////////////////// Variant 1 ////////////////////////////////////////////

           // int[] numbers = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();             
           // SortedDictionary<int, int> dictionary = new SortedDictionary<int,int>();

           //foreach (int number in numbers)
           // {
           //     if (dictionary.ContainsKey(number))
           //     {
           //         dictionary[number]++;
           //     }
           //     else
           //     {
           //         dictionary.Add(number, 1);
           //     }
               
           // }
           // foreach (var number in dictionary)
           // {
           //     Console.WriteLine($"{number.Key} -> {number.Value}");
           // }

            List<int> numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Dictionary<int,int> occurences = new Dictionary<int,int>();
            foreach(int number in numbers)
            {
                if(occurences.ContainsKey(number))
                {
                    occurences[number]++;
                }
                else
                {
                    occurences.Add(number, 1);
                }
            }
            foreach(var item in occurences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");   
            }


        }
    }
}
