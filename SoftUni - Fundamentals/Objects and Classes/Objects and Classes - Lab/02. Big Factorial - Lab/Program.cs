using System;
using System.Numerics;

namespace _02._Big_Factorial___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 1; i <= number; i++)
            {

                result *= i;
               
            }
            Console.WriteLine(result);
        }
    }
}
