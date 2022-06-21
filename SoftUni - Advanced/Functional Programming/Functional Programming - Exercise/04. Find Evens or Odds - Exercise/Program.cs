using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Predicate<int> even = x => x % 2 == 0;
            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", x));

            int[] range = Console.ReadLine()
                 .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string condition = Console.ReadLine();

            int start = range[0];
            int end = range[1];

            List<int> numbers = new List<int>();

            for (int k = start; k <= end; k++)
            {
                numbers.Add(k);
            }

            if (condition == "odd")
            {
                numbers.RemoveAll(even);
            }
            else if (condition == "even")
            {
                numbers.RemoveAll(x => !even(x));
            }

            print(numbers);
        }
    }
}
