using System;
using System.Linq;

namespace _2._Squares_in_Matrix___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rowCount =input[0];
            int colCount =input[1];
            string[,] matrix = new string[rowCount, colCount];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] text = Console.ReadLine().Split(" ");
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = text[col];
                }
            }
            int count = 0;
            for (int row = 0; row < rowCount - 1; row++)
            {
                for (int col = 0; col < colCount - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row,col]==matrix[row + 1, col] && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
                Console.WriteLine(count);
        }
    }
}
