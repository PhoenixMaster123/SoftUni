using System;

namespace _02._New_SoftUni_Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int height = size + size / 2;
            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < size; k++)
                {
                    int result = i + k;
                    if (result % 4 == 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();

            }
        }
    }
}
