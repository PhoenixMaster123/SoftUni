using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            for (int i = 0;i<n;i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            for (int i = number.Length-1; i >= 0; i--)

            {
                Console.Write(number[i] + " "); 
            }
           // Console.WriteLine(string.Join(" ", number)); // short nachin na cikula
            Console.WriteLine();
        }
    }
}
