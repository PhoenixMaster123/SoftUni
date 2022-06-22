using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////// First Variant ///////////////////////////////////////////

            //List<int> elements = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            //int divider = int.Parse(Console.ReadLine());

            //Predicate<int> isDevisible = x => x % divider == 0;
            //Action<List<int>> print = x => Console.WriteLine(string.Join(" ", x));
            //elements.Reverse();
            //elements.RemoveAll(isDevisible);
            //print(elements);

            ///////////////////////////////////////////////////////////////////////// Second Variant ///////////////////////////////////////////
            
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int divisibleNum = int.Parse(Console.ReadLine());
            Predicate<int> filter = numbers => numbers % divisibleNum != 0;
            //Console.WriteLine(string.Join(" ", numbers.Reverse().Where(x => filter(x))));
            Action<int[]> print = number => Console.WriteLine(string.Join(" ", number.Reverse().Where(x => filter(x))));
            print(numbers);

        }
    }
}
