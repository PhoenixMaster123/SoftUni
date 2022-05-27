using System;

namespace _08._Math_Power
{
    internal class Program
    {
        ////////////////////////////// Variant 1 /////////////////////////
        //static void Main(string[] args)
        //{
        //    double @base = double.Parse(Console.ReadLine());
        //    double power = double.Parse(Console.ReadLine());
        //     double powerResult = PrintPowerNumberBase(@base,power);
        //    Console.WriteLine(powerResult);
        //}
        //static double PrintPowerNumberBase(double @base, double power)
        //{
        //    double result = 1;
        //    for (int i = 0; i < power; i++)
        //    {
        //        result = result*@base;
        //    }
        //    return result;


        //   // return Math.Pow(baseNumber, power);
        //}
        ///////////////////////////////////// Second Variant - My //////////////////
        static void Main(string[] args)
        {
        double baseNumber = double.Parse(Console.ReadLine());
        double power = double.Parse(Console.ReadLine());
        Console.WriteLine(PrintPowerNumberBase(baseNumber, power));
        }
    static double PrintPowerNumberBase(double baseNumber, double power)
    {
        return Math.Pow(baseNumber, power);
    }
}
}
