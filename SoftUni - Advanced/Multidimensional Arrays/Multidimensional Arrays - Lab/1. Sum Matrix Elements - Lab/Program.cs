using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimention = Console.ReadLine().Split(", ").Select(int.Parse).ToArray(); // Read the matrix dimension -> rows,cols
            //int[,] matrix = new int[dimention[0], dimention[1]]; // another variant
            int rowsCount = dimention[0]; 
            int colsCount = dimention[1];
            //(int rows,int cols) = (dimention[0],dimention[1]); // short version

            // Read the numbers for the matrix
            int[,] matrix = new int[rowsCount, colsCount];
            for (int rows = 0; rows < rowsCount; rows++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int cols = 0; cols < colsCount; cols++)
                {
                    matrix[rows,cols] = line[cols];
                }
            }
            long sum = 0;
            for (int row = 0; row < rowsCount; row++)
            {
                
                for (int col = 0; col < colsCount; col++)
                {
                    sum += matrix[row, col];
                }
            }
            Console.WriteLine(rowsCount);
            Console.WriteLine(colsCount);
            Console.WriteLine(sum);
            
        }
    }
}
