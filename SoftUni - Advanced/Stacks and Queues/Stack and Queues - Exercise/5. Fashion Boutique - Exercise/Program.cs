using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] allClothesInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> allClothes = new Stack<int>(allClothesInput);
            int boxCapacity = int.Parse(Console.ReadLine());
            int currentRackCapacity = boxCapacity;
            int racksCount = 1;

            while (allClothes.Any())
            {
                int clothes = allClothes.Pop();
                currentRackCapacity -= clothes;
                if (currentRackCapacity < 0)
                {
                    racksCount++;
                    currentRackCapacity = boxCapacity - clothes;
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}