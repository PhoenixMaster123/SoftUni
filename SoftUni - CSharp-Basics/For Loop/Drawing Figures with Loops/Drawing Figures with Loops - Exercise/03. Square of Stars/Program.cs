using System;

namespace _03._Square_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int square = int.Parse(Console.ReadLine());
            for (int row = 1; row <= square; row++)
            {
                for (int col = 0; col < square; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
