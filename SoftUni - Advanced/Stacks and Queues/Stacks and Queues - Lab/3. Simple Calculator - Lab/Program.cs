using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> calculator = new Stack<string>(Console.ReadLine().Split().Reverse().ToArray());

            while (calculator.Count > 1)
            {
                int a = int.Parse(calculator.Pop());
                string sign = calculator.Pop();
                int b = int.Parse(calculator.Pop());

                if (sign == "+")
                {
                    calculator.Push((a + b).ToString());
                }
                else
                {
                    calculator.Push((a - b).ToString());
                }
            }

            Console.WriteLine(calculator.Pop());
        }
    }
}