using System;
using System.Numerics;

namespace Exercise___05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
          BigInteger number1 = BigInteger.Parse(Console.ReadLine());
          BigInteger number2 = BigInteger.Parse(Console.ReadLine());
          BigInteger result =  number1 * number2;
          Console.WriteLine(result);
        }
    }
}
