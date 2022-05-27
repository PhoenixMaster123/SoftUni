using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(MathFunction(num1,symbol,num2));
        }
        static int MathFunction(int num1, char symbol, int num2)
        {
            int result = 0;
            if (symbol == '*')
            {
                result = num1 * num2;
            }
            else if(symbol == '+')
            {
                result = num1 + num2;
            }
            else if(symbol == '-')
            {
                result = num1 - num2;
            }
            else
            {
                result = num1 / num2;
            }
            return result;
        }
    }
}
