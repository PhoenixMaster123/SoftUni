using System;
using System.Linq;

namespace _2._Recursive_Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Symbols(n);
        }
        private static void Symbols(int figures)
        {
            if (figures == 0) 
            {
                return;
            }
            Console.WriteLine(new string('*', figures));

            Symbols(figures - 1);

            Console.WriteLine(new string('#', figures));

        }
    }
}
