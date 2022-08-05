using System;

namespace T1___Birthday_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double tortePrice = rent * 0.2;
            double drinks = tortePrice - tortePrice * 0.45;
            double animator = rent / 3;
            double total = rent + tortePrice + drinks + animator;
            Console.WriteLine($"{total}");
        }
    }
}
