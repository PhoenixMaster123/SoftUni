using System;

namespace _02._Rectangle_of_N_x_N_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rectangle = int.Parse(Console.ReadLine());
            for (int row = 1; row <= rectangle; row++)
            {
                for (int col = 1; col <= rectangle; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
