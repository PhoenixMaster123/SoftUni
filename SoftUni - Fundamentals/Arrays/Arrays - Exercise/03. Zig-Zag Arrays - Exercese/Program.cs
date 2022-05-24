using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays___Exercese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] items = new int[n];
            int[]tools = new int[n];
            for (int row = 1; row <= n; row++) 
            {
                int[] currentRowData = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int firstNumber = currentRowData[0];
                int secondNumber =currentRowData[1];
                if (row % 2 != 0)
                {
                    //Odd
                    items[row-1] = firstNumber;
                    tools[row-1] = secondNumber;
                }
                else
                {   //Even                                   
                    items[row - 1] = secondNumber;
                    tools[row - 1] = firstNumber;
                }
              
            }
            Console.WriteLine(string.Join(" ", items));
            Console.WriteLine(string.Join(" ", tools));           
        }
    }
}
