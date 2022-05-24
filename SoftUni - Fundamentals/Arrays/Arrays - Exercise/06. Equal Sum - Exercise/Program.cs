using System;
using System.Linq;

namespace _06._Equal_Sum___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int[] number = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool isFound = false;
            for (int i = 0; i < number.Length; i++)
            {
                int leftSum = 0;
                for(int j=0; j<i; j++)
                {
                    leftSum+=number[j];
                }
                int rightSum = 0;
                for (int k = number.Length-1; k > i; k--)
                {
                    rightSum += number[k];
                }
                if (leftSum == rightSum && !isFound)
                {
                    Console.WriteLine(i);
                    isFound = true;
                }
            }
            if(!isFound)
            {
                Console.WriteLine("no");
            }

        }
    }
}
