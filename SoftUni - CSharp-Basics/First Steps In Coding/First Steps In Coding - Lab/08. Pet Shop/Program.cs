using System;

namespace _08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int empty = int.Parse(Console.ReadLine());

            double fooddogs = dogs * 2.50;
            double foodempty = empty * 4;
            double result = fooddogs + foodempty;
            Console.WriteLine($"{result} lv.");
        }
    }
}
