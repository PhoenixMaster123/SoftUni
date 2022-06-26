using System;
using System.Linq;

namespace _3._Generating_0_1_Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int [n];

            Gener01(arr, 0);
        }
        private static void Gener01(int[] arr, int com)
        {
            if (com >= arr.Length)
            {
                Console.WriteLine(string.Join(string.Empty, arr));
                return;
            }
            for (int i = 0; i < 2; i++)
            {
                arr[com] = i;

                Gener01(arr, com + 1);
            }
        }
    }
}
