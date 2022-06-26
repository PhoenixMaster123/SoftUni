using System;
using System.Linq;

namespace _4._Recursive_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Multiply(n));
        }
        private  static int Multiply(int n)
        {
            if (n == 0)
            { 
                return 1;
            }
            else
            {
                return n * Multiply(n - 1);
            }
        }
    }
}
