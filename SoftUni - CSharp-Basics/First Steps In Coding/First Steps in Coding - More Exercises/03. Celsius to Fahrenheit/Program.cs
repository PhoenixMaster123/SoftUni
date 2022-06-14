using System;

namespace _03._Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double c = double.Parse(Console.ReadLine());
            double result = c * 1.8 + 32;
            Console.WriteLine("{0:0.00}", result);
        }
    }
}
