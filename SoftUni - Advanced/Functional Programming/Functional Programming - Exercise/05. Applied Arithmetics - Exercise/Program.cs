using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", x));
            Func<List<int>, List<int>> add = x => x.Select(x => x + 1).ToList();
            Func<List<int>, List<int>> multiply = x => x.Select(x => x * 2).ToList();
            Func<List<int>, List<int>> subtract = x => x.Select(x => x - 1).ToList();

            List<int> numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "add")
                {
                    numbers = add(numbers);
                }
                else if (command == "multiply")
                {
                    numbers = multiply(numbers);
                }
                else if (command == "subtract")
                {
                    numbers = subtract(numbers);
                }
                else if (command == "print")
                {
                    print(numbers);
                }

                command = Console.ReadLine();
            }
        }
    }
}
