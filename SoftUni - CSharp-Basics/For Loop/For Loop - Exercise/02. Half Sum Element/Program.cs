using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int value = int.MinValue;
            int sum = 0;
            for(int i=0;i<n;i++)
            {
                int allnumbers = int.Parse(Console.ReadLine());
                sum += allnumbers;

                if (allnumbers>value)
                {
                    value = allnumbers;
                    
                }
            }
            int without = sum - value;
            if(without==value)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {value}");
            }
            else
            {
                int diff = Math.Abs(value - without);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");

            }
        }
    }
}
