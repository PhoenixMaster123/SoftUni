using System;

namespace _4._Symbol_in_Matrix___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int index = int.Parse(Console.ReadLine());
          int[,] matrix = new int[index,index];
            for (int row = 0; row < index; row++)
            {
                string text = Console.ReadLine();
                for (int col = 0; col < index; col++)
                {
                    matrix[row,col] = text[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            for (int row = 0; row < index; row++)
            {
                for (int col = 0; col < index; col++)
                {
                    if(matrix[row,col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                    
                }
            }
           Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
