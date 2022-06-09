using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowsCount = dimension[0];
            int colsCount = dimension[1];
            int[,] matrix = new int[rowsCount, colsCount];
            for (int rows = 0; rows < rowsCount; rows++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int cols = 0; cols < colsCount; cols++)
                {
                    matrix[rows, cols] = line[cols];
                }
            }
            int maxSum = int.MinValue;
            string theBestSquare = string.Empty;
            for (int rows = 0; rows < rowsCount-1; rows++)
            {
                for (int cols = 0;cols < colsCount-1; cols++)
                {
                    int sum = matrix[rows, cols] + matrix[rows, cols+1] + matrix[rows+1, cols] + matrix[rows+1,cols+1];
                    if(sum > maxSum)
                    {
                        maxSum = sum;
                        theBestSquare = matrix[rows, cols] + " " + matrix[rows, cols + 1] + "\r\n" + matrix[rows + 1, cols] + " " + matrix[rows + 1, cols + 1];
                    }
                }
            }
            Console.WriteLine(theBestSquare);
            Console.WriteLine(maxSum);
        }
    }
}
