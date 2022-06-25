using System;
using System.Linq;

namespace _4.Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            var lake = new Lake(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Console.WriteLine(string .Join( ", ",lake ));
        }
    }
}
