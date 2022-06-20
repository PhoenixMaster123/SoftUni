using System;

namespace _10._Multiply_by_2
{
    internal class Program
    {
        static void Main(string[] args)
        {           
                double number = double.Parse(Console.ReadLine());
                while (true)
                {
                    if (number < 0)
                    {
                        Console.WriteLine("Negative number!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Result: {number * 2:F2}");
                    }
                    number = double.Parse(Console.ReadLine());
                }
        }
    }
}
