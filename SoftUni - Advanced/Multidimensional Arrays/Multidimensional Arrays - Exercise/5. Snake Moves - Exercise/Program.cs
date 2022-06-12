using System;
using System.Linq;

namespace _5._Snake_Moves___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] dimension = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           int rowCount = dimension[0];
           int columnCount = dimension[1];

           char[,] matrix = new char[rowCount, columnCount];
           string text = Console.ReadLine();
            int index = 0;


            for (int rows = 0; rows < rowCount; rows++)
            {
                if (rows % 2 == 0)   // even row
                {
                    for (int col = 0; col < columnCount; col++)
                    {
                        matrix[rows, col] = text[index];
                        index++;
                        if(index>=text.Length)
                        {
                            index = 0;
                        }
                    }
                  

                }
                else // odd row
                {
                    for (int col = columnCount-1; col >= 0; col--)
                    {
                        matrix[rows, col] = text[index];
                        index++;
                        if (index >= text.Length)
                        {
                            index = 0;
                        }
                    }
                   
                    
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
            // PrintMatrix(matrix);


        }
        //private static void PrintMatrix(char[,] matrix)
        //{
        //    for (int row = 0; row < matrix.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < matrix.GetLength(1); col++)
        //        {
        //            Console.Write(matrix[row, col]);
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
