using System;
using System.Collections.Generic;

namespace _03._Periodic_Table___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            SortedSet<string> chemicalSymbols = new SortedSet<string>();
            for (int i = 0; i < input; i++)
            {
                string[] token = Console.ReadLine().Split(' ');
                for (int k = 0; k < token.Length; k++)
                {
                    chemicalSymbols.Add(token[k]);
                }
               
            }
            Console.WriteLine(string.Join(" ",chemicalSymbols));
        }
    }
}
