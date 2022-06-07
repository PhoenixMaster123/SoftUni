using System;

namespace _04._Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double inches = number * 2.54;
            Console.WriteLine(inches);
        }
    }
}
