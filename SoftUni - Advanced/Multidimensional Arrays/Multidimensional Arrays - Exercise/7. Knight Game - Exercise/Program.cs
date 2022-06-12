using System;
using System.Linq;

namespace _7_Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            char[][] jagged = new char[rowsCount][];
            for (int row = 0; row < rowsCount; row++)
            {
                char[] knights = Console.ReadLine().ToCharArray();
                jagged[row] = knights;
            }


            int removedKnights = 0;

            while (true)
            {
                int knightRow = -1;
                int knightCol = -1;
                int maxAttacked = 0;
                for (int row = 0; row < rowsCount; row++)
                {
                    for (int col = 0; col < rowsCount; col++)
                    {
                        if (jagged[row][col] == 'K')
                        {
                            int tempAttack = CountAttaks(jagged, row, col);
                            if (tempAttack > maxAttacked)
                            {
                                maxAttacked = tempAttack;
                                knightRow = row;
                                knightCol = col;
                            }
                        }
                    }
                }

                if (maxAttacked > 0)
                {
                    jagged[knightRow][knightCol] = '0';
                    removedKnights++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(removedKnights);
        }

        static int CountAttaks(char[][] jagged, int row, int col)
        {
            int attacks = 0;
            if (IsExist(row + 1, col - 2, jagged.Length) && jagged[row + 1][col - 2] == 'K')
            {
                attacks++;
            }

            if (IsExist(row - 1, col - 2, jagged.Length) && jagged[row - 1][col - 2] == 'K')
            {
                attacks++;
            }

            if (IsExist(row - 1, col + 2, jagged.Length) && jagged[row - 1][col + 2] == 'K')
            {
                attacks++;
            }

            if (IsExist(row + 1, col + 2, jagged.Length) && jagged[row + 1][col + 2] == 'K')
            {
                attacks++;
            }

            if (IsExist(row - 2, col - 1, jagged.Length) && jagged[row - 2][col - 1] == 'K')
            {
                attacks++;
            }

            if (IsExist(row - 2, col + 1, jagged.Length) && jagged[row - 2][col + 1] == 'K')
            {
                attacks++;
            }

            if (IsExist(row + 2, col - 1, jagged.Length) && jagged[row + 2][col - 1] == 'K')
            {
                attacks++;
            }
            if (IsExist(row + 2, col + 1, jagged.Length) && jagged[row + 2][col + 1] == 'K')
            {
                attacks++;
            }
            return attacks;
        }

        public static bool IsExist(int row, int col, int lenght)
        {
            return row >= 0 && row < lenght && col >= 0 && col < lenght;
        }
    }
}
