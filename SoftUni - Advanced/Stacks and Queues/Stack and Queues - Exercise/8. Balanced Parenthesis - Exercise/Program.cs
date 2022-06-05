using System;
using System.Collections.Generic;
using System.Linq;

namespace BalancedParenthesis
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char bracket = input[i];

                if (bracket == '(' || bracket == '[' || bracket == '{')
                {
                    stack.Push(bracket);
                }
                else if (bracket == ')' && stack.Any() || bracket == ']' && stack.Any() || bracket == '}' && stack.Any())

                {

                    char currentBracket = input[i];
                    char stackBracket = stack.Pop();

                    if (stackBracket == '(' && currentBracket == ')')
                    {
                        continue;
                    }
                    else if (stackBracket == '[' && currentBracket == ']')
                    {
                        continue;
                    }
                    else if (stackBracket == '{' && currentBracket == '}')
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}