using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstLenght = items.Length;
            for (int i = 0; i < firstLenght-1; i++)
            {
                int[] condensed = new int[items.Length-1];
                for (int j = 0; j < items.Length-1; j++)
                {
                    condensed[j] = items[j] + items[j + 1];
                }
                items = condensed;
            }
            Console.WriteLine(items[0]);
        }
    }
}
