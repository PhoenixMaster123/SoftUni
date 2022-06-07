using System;

namespace _09._Yard_Greening
{
    class Program
    {
        static void Main(string[] args)
        {
            double quadratmeters = double.Parse(Console.ReadLine());
            double persent = 0.18;
            quadratmeters = quadratmeters * 7.61;
            persent = persent * quadratmeters;
            double result = quadratmeters - persent;
            Console.WriteLine($"The final price is: {result} lv.");
            Console.WriteLine($"The discount is: {persent} lv.");
        }
    }
}
