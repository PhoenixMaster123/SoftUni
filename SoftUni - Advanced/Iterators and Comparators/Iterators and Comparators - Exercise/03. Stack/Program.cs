using System;
using System.Linq;

namespace _3.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();

            while (true)
            {
                var tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens[0] == "END")
                {
                    break;
                }
                else if (tokens[0] == "Push")
                {
                    stack.Push(tokens.Skip(1).Select(t => t.Split(',').First()).ToArray());
                }
                else if (tokens[0] == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }
                }
            }

            foreach (string element in stack)
            {
                Console.WriteLine(element);
            }
            foreach (string element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
