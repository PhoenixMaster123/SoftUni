using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] number = Console.ReadLine().Split().Select(double.Parse).ToArray();           
            for (int i = 0; i < number.Length; i++)
            {                
                Console.WriteLine($"{number[i]} => {Math.Round(number[i],MidpointRounding.AwayFromZero)}");
            }
            /////////////////////////////////////// Variant 2 ///////////////////////////////////////////////////////////
            //string[] rawinput = Console.ReadLine().Split();
            //double[] items = new double[number.Length];
            //for (int i = 0; i < rawinput.Length; i++)
            //{
            //    items[i] = double.Parse(rawinput[i]);
            //}
            //for (int i = 0; i < items.Length; i++)
            //{
            //    Console.WriteLine($"{items[i]} => {Math.Round(items[i], MidpointRounding.AwayFromZero)}");
            //}

        }
    }
}
