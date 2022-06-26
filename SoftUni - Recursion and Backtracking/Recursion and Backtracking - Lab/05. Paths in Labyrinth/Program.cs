using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Find_All_Paths_in_a_Labyrinth
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            int colsCount = int.Parse(Console.ReadLine());
            char[,] matrix = new char[rowsCount, colsCount];
            for (int row = 0; row < rowsCount; row++)
            {
                string colElement = Console.ReadLine();

                for (int col = 0; col < colsCount; col++)
                {
                    matrix[row, col] = colElement[col];
                }
            }
            FindPaths(matrix, 0, 0, new List<string>(), string.Empty);
        }

        private static void FindPaths(char[,] lab, int row, int cow, List<string> directions, string direction)
        {

            if (row < 0 || row >= lab.GetLength(0) || cow < 0 || cow >= lab.GetLength(1)) 
            {
                return;
            }
            if (lab[row, cow] == '*' || lab[row, cow] == 'v')
            {
                return;
            }
            directions.Add(direction);
            if (lab[row,cow] == 'e')
            {
                Console.WriteLine(string.Join(string.Empty, directions));
                directions.RemoveAt(directions.Count - 1);
                return;
            }
            lab[row,cow] = 'v';
           
            FindPaths(lab, row - 1, cow, directions, "U"); //UP
            FindPaths(lab, row + 1, cow, directions, "D"); //Down
            FindPaths(lab, row, cow - 1, directions, "L") ; //Left
            FindPaths(lab, row, cow + 1, directions, "R"); //Right

            lab[row, cow] = '-';
            directions.RemoveAt(directions.Count - 1);
        }

      
    }
}
