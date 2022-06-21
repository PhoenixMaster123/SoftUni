using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Custom_Min_Function___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////// First Variant //////////////////////////////////////////

            //List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            //Console.WriteLine(input.Min());

            ////////////////////////////////////////////////// Second Variant //////////////////////////////////////////
            //Func<int[], int> minNumber = n => n.Min();
            //int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //Console.WriteLine(minNumber(numbers));

            ////////////////////////////////////////////////// Third Variant //////////////////////////////////////////
            int number = Console.ReadLine().Split().Select(int.Parse).Min();
            Console.WriteLine(number);
        }
    }
}
