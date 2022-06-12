using System;

namespace _01._Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 23; i++)
            {
                for (int n = 0; n <= 59; n++)
                {
                    Console.WriteLine($"{i}:{n}");
                }
            }
        }
    }
}
