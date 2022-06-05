using System;
using System.Collections;
using System.Collections.Generic;

namespace _1._Reverse_Strings___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////// First Variant /////////////////////////////
            //string input = Console.ReadLine();

            //Stack<string> stack = new Stack<string>();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    stack.Push(String.Format($"{input[i]}"));
            //}
            //Console.WriteLine(string.Join("",stack));

            ////////////////////////////////////////////////////////////// Second Variant ////////////////////////////
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (char ch in input)
            {
                stack.Push(ch);
            }
            while(stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
