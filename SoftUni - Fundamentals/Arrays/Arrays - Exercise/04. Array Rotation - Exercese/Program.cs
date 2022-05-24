using System;
using System.Linq;

namespace _04._Array_Rotation___Exercese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] items = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rotetionsCount = int.Parse(Console.ReadLine());
           
            for (int rot = 1; rot <= rotetionsCount; rot++)
            {
                int firstElement = items[0];
                for (int i = 0; i <= items.Length - 2; i++)
                {
                    items[i] = items[i + 1];
                }
                items[items.Length - 1] = firstElement;
            }
           
            Console.WriteLine(string.Join(" ",items));
        }
    }
}
