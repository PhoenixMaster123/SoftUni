using System;

namespace _01._Rectangle_of_10_x_10_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
