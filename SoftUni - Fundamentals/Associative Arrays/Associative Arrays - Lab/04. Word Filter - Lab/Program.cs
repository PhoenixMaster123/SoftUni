using System;
using System.Linq;

namespace _04._Word_Filter___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine()
                                       .Split(" ").Where(x => x.Length % 2 == 0)
                                      .ToArray();
            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}
