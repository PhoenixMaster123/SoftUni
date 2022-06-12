using System;
using System.Linq;

namespace _4._Matrix_Shuffling___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rowsCount = dimension[0];
            int columnsCount = dimension[1];
            string[,] matrix = new string[rowsCount, columnsCount];
            for (int row = 0; row < rowsCount; row++)
            {
                string[] numbers = Console.ReadLine().Split(' ');
                for (int col = 0; col < columnsCount; col++) 
                {
                    matrix[row,col] = numbers[col];
                }
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] token = command.Split(' ');
                string action = token[0];
                if(action.Equals("swap") && token.Length == 5)
                {
                    int row1 = int.Parse(token[1]);
                    int col1 = int.Parse(token[2]);
                    int row2 = int.Parse(token[3]);
                    int col2 = int.Parse(token[4]);

                    if (row1 >= 0 && row1 < rowsCount && col1 >= 0 && col1 < columnsCount && row2 >= 0 && row2 < rowsCount && col2 >= 0 && col2 < columnsCount)
                    {
                        string firstElement = matrix[row1,col1];
                        string secondElement = matrix[row2,col2];

                        matrix[row2,col2] = firstElement;
                        matrix[row1,col1] = secondElement;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write(matrix[row,col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                      
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                  
                }


                command = Console.ReadLine();
            }
        }
    }
}
