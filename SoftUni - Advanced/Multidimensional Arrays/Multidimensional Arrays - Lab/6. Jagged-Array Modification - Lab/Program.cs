using System;
using System.Linq;

namespace _6._Jagged_Array_Modification___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rowsCount][];
            //////////////////////////////////////////////////////////// First Variant //////////////////////////////
            //for (int row = 0; row < rowsCount; row++)
            //{
            //    jagged[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //}
            ////////////////////////////////////////////////////////// Second Variant //////////////////////////////
            for (int row = 0; row < rowsCount; row++)
            {
                int[] columns = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                jagged[row] = columns;
            }
            string command = Console.ReadLine();
            while (command != "END")
            { 
                string[] token = command.Split(' ').ToArray();
                string action = token[0];
                if(action.Equals("Add"))
                {
                    int row = int.Parse(token[1]);
                    int col = int.Parse(token[2]);
                    int value = int.Parse(token[3]);


                    if (row >= 0 && col >= 0 &&
                        row < rowsCount && col < rowsCount)
                    {
                        jagged[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    
                   
                }
                else if(action.Equals("Subtract"))
                {
                    int row = int.Parse(token[1]);
                    int col = int.Parse(token[2]);
                    int value = int.Parse(token[3]);

                    if (row >= 0 && col >= 0 &&
                        row < rowsCount && col < rowsCount)
                    {
                        jagged[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }

                }
                command = Console.ReadLine();
            }
            /////////////////////////////////////////////// First Variant ///////////////////////////////////////
            foreach(int[] row in jagged)
            {
                Console.WriteLine(string.Join(" ", row)); 
            }
            ///////////////////////////////////////////// Second Variant //////////////////////////////////////
            //for (int row = 0; row < jagged.Length; row++)
            //{
               
            //        Console.WriteLine(string.Join(" ",jagged[row]));
       
            //}
        }
    }
}
