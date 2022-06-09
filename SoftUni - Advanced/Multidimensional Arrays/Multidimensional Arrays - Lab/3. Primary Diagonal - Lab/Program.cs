using System;
using System.Linq;

namespace _3._Primary_Diagonal___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            for (int row = 0; row < size; row++)
            {
                int[] line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row,col] = line[col];
                }
            }
            int sum = 0;
            for (int row = 0;row < size; row++)
            {
               
                for (int col = 0;col < size; col++)
                {

                    sum += matrix[row, col];
                    row++;
                    
                }
               
            }
            Console.WriteLine(sum);
        }
    }
}
