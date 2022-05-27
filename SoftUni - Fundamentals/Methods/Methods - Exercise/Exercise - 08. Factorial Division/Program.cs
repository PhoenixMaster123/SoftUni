using System;

namespace Exercise___08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int factorial = int.Parse(Console.ReadLine());
            int devide = int.Parse(Console.ReadLine());

            double firstFac = Factorial(factorial);
            double secondFac = Factorial(devide);

            double result = firstFac / secondFac;
           
            Console.WriteLine($"{result:F2}");
        }
        static double Factorial(double factorial)
        {
            double result = factorial;
                           
                for (int k = 1; k < factorial; k++)
                {
                    result *= k;
                }
                       
            return result;
        }
    }
}
