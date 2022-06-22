using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {



            ////////////////////////////////////////////////////////////////////////// First Variant //////////////////////////////////////

            //    int numRange = int.Parse(Console.ReadLine());
            //    List<int> divisors = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Distinct().ToList();
            //    var divisibleNumbers = GetDivisibleNumbers(numRange, divisors);

            //    Console.WriteLine(string.Join(" ", divisibleNumbers));
            //}

            //private static List<int> GetDivisibleNumbers(int numRange, List<int> divisors)
            //{
            //    var divisibleNumbers = new List<int>();

            //    for (int num = 1; num <= numRange; num++)
            //    {
            //        var isDivisible = true;

            //        foreach (int d in divisors)
            //        {
            //            Predicate<int> isNotDivisor = x => num % x != 0;

            //            if (isNotDivisor(d))
            //            {
            //                isDivisible = false;
            //                break;
            //            }
            //        }

            //        if (isDivisible)
            //        {
            //            divisibleNumbers.Add(num);
            //        }
            //    }
            //    return divisibleNumbers;

            ////////////////////////////////////////////////////////////////////////// Second Variant //////////////////////////////////////

            int numRange = int.Parse(Console.ReadLine());
            int[] divider = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (numRange <= 0)
            {
                return;
            }

            Func<int[], int, bool> filter = (dividers, number) =>
            {
                bool divisible = true;
                for (int num = 0; num < dividers.Length; num++)
                {
                    if (number % dividers[num] != 0)
                    {
                        divisible = false;
                        break;
                    }
                }
                return divisible;
            };
            int[] divisibleNums = Enumerable.Range(1, numRange).Where(number => filter(divider, number)).ToArray();
            Console.WriteLine(string.Join(" ", divisibleNums));

        }
    }
}


