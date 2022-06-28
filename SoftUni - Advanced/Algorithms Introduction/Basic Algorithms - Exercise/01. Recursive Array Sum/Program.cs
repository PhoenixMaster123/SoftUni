using System;
using System.Linq;

namespace _01._Recursive_Array_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] arrNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           long sum = SumArray(arrNumbers, 0);
           Console.WriteLine(sum);
        }

        private static long SumArray(int[] arrNumbers, int startIndex)
        {
            if (startIndex == arrNumbers.Length - 1) // bottom of recursion
            {
                return arrNumbers[startIndex];
            }
            return arrNumbers[startIndex] + SumArray(arrNumbers, startIndex + 1);
        }
    }
}
