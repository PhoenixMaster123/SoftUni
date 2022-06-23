using System;

namespace _02._Truffle_Hunter___Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int forestSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[forestSize, forestSize];


            for (int row = 0; row < forestSize; row++)
            {
                char[] truffles = Console.ReadLine().Replace(" ", string.Empty).ToCharArray();
                for (int col = 0; col < forestSize; col++)
                {
                    matrix[row, col] = truffles[col];
                }
            }

            int countBlackTruffle = 0;
            int countSummerTruffle = 0;
            int countWhiteTruffle = 0;
            int eatenTruffels = 0;

            string command = Console.ReadLine();
            while (command != "Stop the hunt")
            {
                string[] token = command.Split(' ');
                string action = token[0];
                int row = int.Parse(token[1]);
                int col = int.Parse(token[2]);
                if (action.Equals("Collect"))
                {
                    char truffel = matrix[row, col]; // collect
                    matrix[row, col] = '-';

                    if (truffel == 'B')
                    {
                        countBlackTruffle++;
                    }
                    else if (truffel == 'S')
                    {
                        countSummerTruffle++;
                    }
                    else if (truffel == 'W')
                    {
                        countWhiteTruffle++;
                    }
                }
                else if (action.Equals("Wild_Boar"))
                {
                    string direction = token[3];
                    if (direction.Equals("up"))
                    {
                        while (row >= 0 && row < forestSize)
                        {
                            char currentTruffle = matrix[row, col];
                            if (currentTruffle == 'B' || currentTruffle == 'S' || currentTruffle == 'W')
                            {
                                matrix[row, col] = '-';
                                eatenTruffels++;
                            }
                            row -= 2;
                        }
                    }
                    else if (direction.Equals("down"))
                    {
                        while (row >= 0 && row < forestSize)
                        {
                            char currentTruffle = matrix[row, col];
                            if (currentTruffle == 'B' || currentTruffle == 'S' || currentTruffle == 'W')
                            {
                                matrix[row, col] = '-';
                                eatenTruffels++;
                            }
                            row += 2;
                        }
                    }
                    else if (direction.Equals("right"))
                    {
                        while (col >= 0 && col < forestSize)
                        {
                            char currentTruffle = matrix[row, col];
                            if (currentTruffle == 'B' || currentTruffle == 'S' || currentTruffle == 'W')
                            {
                                matrix[row, col] = '-';
                                eatenTruffels++;
                            }
                            col += 2;
                        }
                    }
                    else if (direction.Equals("left"))
                    {
                        while (col >= 0 && col < forestSize)
                        {
                            char currentTruffle = matrix[row, col];
                            if (currentTruffle == 'B' || currentTruffle == 'S' || currentTruffle == 'W')
                            {
                                matrix[row, col] = '-';
                                eatenTruffels++;
                            }
                            col -= 2;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Peter manages to harvest {countBlackTruffle} black, {countSummerTruffle} summer, and {countWhiteTruffle} white truffles.");
            Console.WriteLine($"The wild boar has eaten {eatenTruffels} truffles.");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
