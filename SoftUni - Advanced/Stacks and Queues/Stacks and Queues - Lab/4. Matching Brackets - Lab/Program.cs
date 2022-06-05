using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> breckets = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                char ch = expression[i];
                if(ch == '(')
                {
                    breckets.Push(i);
                }
                else if(ch == ')')
                {
                    int startIndex = breckets.Pop();
                    int endIndex = i;
                    string subexpression = expression.Substring(startIndex, endIndex - startIndex + 1); ;
                    Console.WriteLine(subexpression);
                }
                        

            
            }
        }
    }
}
