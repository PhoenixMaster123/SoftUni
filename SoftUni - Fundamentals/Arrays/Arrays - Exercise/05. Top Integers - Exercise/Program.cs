using System;
using System.Linq;

namespace _05._Top_Integers___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //////// Worst case -> all integers will be top integers ///////////////////
            int[]topIntegers = new int[arr.Length]; // 0 0 0 0 
            int topIntegersIndex = 0; // Last index that we appeanded to topInteger array
            for (int i = 0;i<=arr.Length-1;i++)
            {
                int currentNumber = arr[i];
                //by default for me is topInteger
                bool isTopInteger = true;
                //Nested loop that loops all indexes right to us to end 
                for (int j = i+1;j<=arr.Length-1;j++)
                {
                    int nextNum = arr[j];
                    if (currentNumber<=nextNum)
                    {
                        //Prove that is topInteger
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    topIntegers[topIntegersIndex] = currentNumber;
                    topIntegersIndex++;
                }
            }
            for (int i = 0; i < topIntegersIndex; i++)
            {
                int currentTopInteger = topIntegers[i];
                Console.Write($"{topIntegers[i]} ");
            }
        }
    }
}
