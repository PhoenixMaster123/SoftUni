using System;

namespace _04._Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vegetables = double.Parse(Console.ReadLine());
            double fruits = double.Parse(Console.ReadLine());
            int kilogramvegetables = int.Parse(Console.ReadLine());
            int kilogramfruits = int.Parse(Console.ReadLine());

            double vegetables1 = vegetables * kilogramvegetables;
            double fruits1 = fruits * kilogramfruits;

            double result = vegetables1 + fruits1;
            result = result / 1.94;
            Console.WriteLine("{0:0.00}", result);
        }
    }
}
