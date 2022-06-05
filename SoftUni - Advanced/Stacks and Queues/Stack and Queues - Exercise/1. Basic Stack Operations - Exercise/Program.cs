using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Basic_Stack_Operations___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int push = array[0];
            int pop = array[1];
            int num = array[2];
            int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < push; i++)
            {  
                stack.Push(number[i]);
            }
            for (int i = 0; i < pop; i++)
            {
                stack.Pop();
            }
            if(stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if(stack.Contains(num))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }

            

        }
    }
}
