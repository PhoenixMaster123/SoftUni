using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////// First Variant /////////////////////////////////////////////

            //int[] dimension = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            //int rowsCount = dimension[0];
            //int colsCount = dimension[1];
            //int[,] matrix = new int[rowsCount, colsCount];
            //for (int row = 0; row < rowsCount; row++) 
            //{
            //    int[] line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            //    for (int col = 0; col < colsCount; col++)
            //    {
            //        matrix[row,col] = line[col];
            //    }
            //}
            //int[] colSum = new int[colsCount];
            //for (int row = 0; row < rowsCount; row++)
            //{
            //    for (int col = 0; col < colsCount; col++)
            //    {
            //       colSum[col] += matrix[row,col];

            //    }
            //}
            //for (int col = 0; col < colsCount; col++)
            //{
            //    Console.WriteLine(colSum[col]);
            //}

            //////////////////////////////////////////////////////////////////////// Second Variant //////////////////////////////////
            int[] dimension = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowsCount = dimension[0];
            int columnsCount = dimension[1];
            int[,] matrix = new int[rowsCount, columnsCount];
            for (int row = 0; row < rowsCount; row++)
            {
                int[] line = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < columnsCount; col++)
                {
                    matrix[row,col] = line[col];
                }

            }
            
            for (int col = 0; col < columnsCount; col++)
            {
                int sumColums = 0;
                for (int row = 0; row < rowsCount; row++)
                {
                   sumColums += matrix[row,col];
                }
                Console.WriteLine(sumColums);
            }
        }
    }
}
