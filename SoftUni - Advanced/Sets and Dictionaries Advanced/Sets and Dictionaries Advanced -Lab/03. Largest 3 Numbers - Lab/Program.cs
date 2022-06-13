using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////////////////////////////////////////////////////////////////////// First Variant /////////////////////////////////

            //List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).ToList();
            //for (int i = 0; i < 3; i++)
            //{
            //    if(i<nums.Count)
            //    {
            //        Console.Write($"{nums[i]} " );
            //    }
            //}

            ////////////////////////////////////////////////////////////////////// Second Variant /////////////////////////////////
            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).ToList().Take(3);
            //Console.WriteLine(string.Join(" ",nums));

            ////////////////////////////////////////////////////////////////////// Third Variant /////////////////////////////////
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).ToArray();
            int count = numbers.Length >= 3 ? 3 : numbers.Length;
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{numbers[i]} ");
            }


        }
    }
}
