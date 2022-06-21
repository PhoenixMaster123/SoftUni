using System;
using System.Linq;

namespace _03._Count_Uppercase_Words___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => char.IsUpper(x[0])).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
