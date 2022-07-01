using System;

namespace _04._Triangle_of_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triangle = int.Parse(Console.ReadLine());
            for (int row = 1; row <= triangle; row++)
            {
                for (int j = 1; j <= row; j++)
                {
                    Console.Write("");
                }
                for (int k = 1; k <= row; k++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine("");
            }
           
        }
    }
}
