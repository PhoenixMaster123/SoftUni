using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int input = int.Parse(Console.ReadLine());
            Dictionary<int,int> dictionaryEvenNumbers = new Dictionary<int, int>(); 
            for (int i = 0; i < input; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(!dictionaryEvenNumbers.ContainsKey(num))
                {
                    dictionaryEvenNumbers.Add(num, 1); ;
                }
                else
                {
                    dictionaryEvenNumbers[num]++;
                }
            }
            ///////////////////////////////////////////////////// First Variant ////////////////////////////////
            Console.WriteLine(dictionaryEvenNumbers.First(entry => entry.Value % 2 == 0).Key);
            ///////////////////////////////////////////////////// Second Variant ////////////////////////////////
            //foreach(var num in dictionaryEvenNumbers)
            //{
            //    if (num.Value % 2 == 0)
            //    {
            //        Console.WriteLine(num.Key);
            //    }
            //}
        }
    }
}
