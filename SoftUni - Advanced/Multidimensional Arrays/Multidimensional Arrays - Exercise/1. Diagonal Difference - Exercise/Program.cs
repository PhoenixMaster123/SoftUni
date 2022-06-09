using System;
using System.Linq;

namespace _1._Diagonal_Difference___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = int.Parse(Console.ReadLine());
            int[,] matrix = new int[index, index];
            for (int rows = 0; rows < index; rows++)
            {
                int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int cols = 0; cols < index; cols++)
                {
                    matrix[rows, cols] = line[cols];
                }
            }
            int sumFirstDiagonal = 0;
            int sumSecondDiagonal = 0;
            for (int rows = 0; rows < index; rows++)
            {
                for (int cols = 0; cols < index; cols++)
                {
                    sumFirstDiagonal += matrix[rows, cols];
                    rows++;
                }
            }
            for (int rows = 0; rows < index; rows++)
            {
                for (int cols = index-1; cols >= 0; cols--)
                {
                    sumSecondDiagonal += matrix[rows, cols];
                    rows++;
                }
            }
            Console.WriteLine(Math.Abs(sumFirstDiagonal-sumSecondDiagonal));
        }
    }
}
