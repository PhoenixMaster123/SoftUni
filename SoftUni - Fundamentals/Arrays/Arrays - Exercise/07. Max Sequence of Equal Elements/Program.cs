using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 1;
            int dublicate = 0;
            int index = arr[0];
            int bestCandidate = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (index == arr[i])
                {
                    count++;
                }
                else
                {
                    index = arr[i];
                    count = 1;
                }
                if (count > bestCandidate)
                {
                    bestCandidate = count;
                    dublicate = arr[i];
                }
            }
            for (int i = 0; i < bestCandidate; i++)
            {
                Console.Write($"{dublicate} ");
            }
        }
    }
}