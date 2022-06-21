using System;
using System.Linq;

namespace _04._Add_VAT___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////// First Variant /////////////////////////////


            //double[] numbers = Console.ReadLine().Split(", ").Select(double.Parse).Select(x => x * 1.2).ToArray();
            //foreach (double price in numbers)
            //{
            //    Console.WriteLine($"{price:F2}");
            //}
            /////////////////////////////////////////////////////////////////// Second Variant /////////////////////////////
            Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).Select(p => p * 1.2m).ToList().ForEach(p => Console.WriteLine($"{p:F2}"));

        }
    }
}
