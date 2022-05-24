using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int currentValue = numbers[i];
               
            //    if (numbers[i] % 2 == 0)
            //    {
            //        sum += currentValue;                  
            //    }
               
            //}
            Console.WriteLine(sum);


        }
    }
}
