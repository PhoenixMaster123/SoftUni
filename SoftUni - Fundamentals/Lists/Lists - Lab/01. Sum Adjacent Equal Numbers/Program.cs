using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> number = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int i = 1; i < number.Count; i++)
            {
                if (number[i] == number[i - 1])
                {
                    number[i] = number[i] + number[i - 1];
                    number.Remove(number[i - 1]);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ",number));
        }
    }
}
