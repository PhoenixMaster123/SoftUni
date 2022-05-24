using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    int[] items = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //    int even = 0;
        //    int odd = 0;
        //    int result = 0;
            //foreach (int item in items)
            //{
            //    if (item % 2 == 0)
            //    { 
            //        even+=item;
            //    }
            //    else
            //    {
            //        odd += item;
            //    }
            //}
            //result = even - odd;
          
            //    Console.WriteLine(result);
            //////////////////////////////////////// Variant 2 //////////////////////////////////////
            string[] rowInput = Console.ReadLine().Split();
            int evenSum = 0;
            int oddSum = 0;
            int result = 0;
            int [] items = new int[rowInput.Length];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = int.Parse(rowInput[i]);
            }
            foreach (var item in items)
            {
                if (item % 2 == 0)
                {
                    evenSum+=item;
                }
                else
                {
                    oddSum += item;
                }
            }
            result = evenSum-oddSum;
            Console.WriteLine(result);
            
            
        }
    }
}
