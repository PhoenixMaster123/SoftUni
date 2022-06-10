using System;

namespace _7._Pascal_Triangle___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int rowsCount = int.Parse(Console.ReadLine());
           long[][] triangle = new long[rowsCount][];
            for (int row = 0; row < rowsCount; row++)
            {
                triangle[row] = new long[row+1];
                triangle[row][0] = 1;
                for (int col = 1; col < row; col++)
                {
                    triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
                }
                triangle[row][row] = 1;
            }
            //////////////////////////////////////////////////////////// First Variant ////////////////////////////////
            //foreach (int[] row in triangle)
            //{
            //    Console.WriteLine(string.Join(" ",row));
            //}
            ////////////////////////////////////////////////////////// Second Variant ////////////////////////////////
            for (int row = 0; row < triangle.Length; row++)
            {
                Console.WriteLine(string.Join(" ", triangle[row]));
            }
          

        }
    }
}
