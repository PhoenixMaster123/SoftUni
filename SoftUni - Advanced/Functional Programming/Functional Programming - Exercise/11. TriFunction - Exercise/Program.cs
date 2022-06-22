using System;
using System.Linq;

namespace _11._TriFunction___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(' ');

            Func<string, int, bool> validator = (name, value) => name.ToCharArray().Select(currChar => (int)currChar).Sum() >= numbers;
            Func<string[], int, Func<string, int, bool>, string> foundName = (collection, value, func) => collection.FirstOrDefault(name => func(name, value));

            Console.WriteLine(foundName(names, numbers, validator));
        }
    }
}
