using System;

namespace _14._Birthday_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double room = double.Parse(Console.ReadLine());
            double torte = room  * 0.20;
            double drinks = torte - torte * 0.45;
            double animator = room * 1 / 3 ;
            Console.WriteLine(room+torte+drinks+animator);
        }
    }
}
