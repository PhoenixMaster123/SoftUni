using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rowsCount][];
            for (int row = 0; row < rowsCount; row++)
            {
                int[] columns = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                jagged[row] = columns;
            }

            for (int row = 0; row < rowsCount-1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    jagged[row] = jagged[row].Select(el => el * 2).ToArray();
                    jagged[row + 1] = jagged[row+1].Select(el => el * 2).ToArray();
                }
                else
                {
                    jagged[row] = jagged[row].Select(el => el / 2).ToArray();
                    jagged[row + 1] = jagged[row+1].Select(el => el / 2).ToArray();
                }
            }



           string command = Console.ReadLine();
            while(command!="End")
            {
                string[] token = command.Split(' ').ToArray();
                string action = token[0];
                if (action.Equals("Add"))
                {
                    int row = int.Parse(token[1]);
                    int col = int.Parse(token[2]);
                    int value = int.Parse(token[3]);


                    if (row >= 0 && col >= 0 && row < rowsCount && col < jagged[row].Length)
                    {
                        jagged[row][col] += value;
                    }

                }
                else if (action.Equals("Subtract"))
                {
                    int row = int.Parse(token[1]);
                    int col = int.Parse(token[2]);
                    int value = int.Parse(token[3]);

                    if (row >= 0 && col >= 0 && row < rowsCount && col < jagged[row].Length)
                    {
                        jagged[row][col] -= value;
                    }

                }
                command = Console.ReadLine();
            }
            foreach (int[] row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
