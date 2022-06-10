using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumeven = 0;
            int sumodd = 0;
            for(int i=0;i<n;i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0) 
                {
                    sumeven += number;
                }
                else
                {
                    sumodd += number;
                }
            }
            if (sumeven == sumodd)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sumeven}");
            }
            else if (sumeven != sumodd)
            {
                int diff = sumeven - sumodd;
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(diff)}");
            }

        }
    }
}
