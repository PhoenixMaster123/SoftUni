using System;
using System.Linq;

namespace Recursive_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Sum(numbers, 0));
        }
        private static int Sum(int[] numbers, int num)
        {
            if (num == numbers.Length - 1)
            { 
                return numbers[num];
            }

            return numbers[num] + Sum(numbers,num + 1);
        }
    }
}
