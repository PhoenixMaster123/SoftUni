using System;

namespace Problem2
{
    internal class Program
    {

        private static char[,] wallMatrix;
        static void Main(string[] args)
        {
            int wallSize = int.Parse(Console.ReadLine());
            int VankoRowCordinates = 0;
            int VankoColCordinates = 0;
            int newRow = 0;
            int newCol = 0;
            wallMatrix = new char[wallSize, wallSize];

            for (int row = 0; row < wallSize; row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < wallSize; col++)
                {
                    wallMatrix[row, col] = rowData[col];

                    if (wallMatrix[row, col] == 'V')
                    {
                        VankoRowCordinates = row;
                        VankoColCordinates = col;
                    }
                }
            }

            int rodsHit = 0;
            int holesMade = 1;
            bool isElectrocuted = false;

            while (true)
            {
                string direction = Console.ReadLine();
                if (direction == "End")
                {
                    break;
                }

                (newRow, newCol) = VankosMovement(VankoRowCordinates, VankoColCordinates, direction);
                if (!IfCordinatesAreValid(newRow, newCol))
                {
                    continue;
                }

                if (wallMatrix[newRow, newCol] == 'R')
                {
                    rodsHit++;
                    Console.WriteLine("Vanko hit a rod!");
                    continue;
                }

                wallMatrix[VankoRowCordinates, VankoColCordinates] = '*';
                (VankoRowCordinates, VankoColCordinates) = (newRow, newCol);

                if (wallMatrix[VankoRowCordinates, VankoColCordinates] == 'C')
                {
                    wallMatrix[VankoRowCordinates, VankoColCordinates] = 'E';
                    holesMade++;
                    isElectrocuted = true;
                    break;
                }
                else if (wallMatrix[VankoRowCordinates, VankoColCordinates] == '*')
                {
                    Console.WriteLine($"The wall is already destroyed at position [{VankoRowCordinates}, {VankoColCordinates}]!");
                }
                else
                {
                    holesMade++;
                }

                wallMatrix[VankoRowCordinates, VankoColCordinates] = 'V';
            }

            if (isElectrocuted == true)
            {
                Console.WriteLine($"Vanko got electrocuted, but he managed to make {holesMade} hole(s).");
            }
            else
            {
                Console.WriteLine($"Vanko managed to make {holesMade} hole(s) and he hit only {rodsHit} rod(s).");
            }
            for (int rows = 0; rows < wallMatrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < wallMatrix.GetLength(1); cols++)
                {
                    Console.Write(wallMatrix[rows, cols]);
                }

                Console.WriteLine();
            }
        }

        public static (int, int) VankosMovement(int row, int col, string direction)
        {
            switch (direction)
            {
                case "up":
                    row--;
                    break;
                case "down":
                    row++;
                    break;
                case "left":
                    col--;
                    break;
                case "right":
                    col++;
                    break;
            }

            return (row, col);
        }
        static bool IfCordinatesAreValid(int row, int col)
        {
            return row >= 0 && row < wallMatrix.GetLength(0) && col >= 0 && col < wallMatrix.GetLength(1);
        }
    }
}