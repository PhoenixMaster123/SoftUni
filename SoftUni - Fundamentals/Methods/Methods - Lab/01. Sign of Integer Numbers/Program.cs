using System;

namespace _01._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
            Number(number);
        }
        static void Number(int num)
        {
            if(num>0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if(num<0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }

    }
}
