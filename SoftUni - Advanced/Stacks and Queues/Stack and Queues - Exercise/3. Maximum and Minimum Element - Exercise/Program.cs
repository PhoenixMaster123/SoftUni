using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximum_and_Minimum_Element___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int count = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < count; i++)
            {
                int[] token = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int command = token[0];
               
                if (command.Equals(1))
                {
                    int number = token[1];
                    stack.Push(number);
                }
                else if (command.Equals(2) && stack.Any())
                {
                    stack.Pop();
                }
                else if(command.Equals(3) && stack.Any())
                {
                    Console.WriteLine(stack.Max());
                   
                }
                else if(command.Equals(4) && stack.Any())
                {
                    Console.WriteLine(stack.Min());
                    
                }
               
            }
            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
