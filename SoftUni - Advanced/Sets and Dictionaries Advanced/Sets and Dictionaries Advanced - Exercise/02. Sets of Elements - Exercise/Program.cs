using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] length = Console.ReadLine().Split(' ');
            int n = int.Parse(length[0]);
            int m = int.Parse(length[1]);
            HashSet<int> firstValues = new HashSet<int>();
            HashSet<int> secondValues = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                firstValues.Add(numbers);
            }
            for (int k = 0; k < m; k++)
            {
                int numbers = int.Parse(Console.ReadLine());
                secondValues.Add(numbers);
            }

            firstValues.IntersectWith(secondValues);
            Console.Write(string.Join(" ", firstValues));


        }
    }
}
