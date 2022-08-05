using System;

namespace T1___Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double joan = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());
            comision = comision / 100;
            

            bitcoin = bitcoin * 1168;
            joan = joan * 0.15;
            double dolar = 1.76;
            double euro = 1.95;

            double lev = joan * dolar;
            double result = lev + bitcoin;
            result = result / euro;
            comision = result * comision;
            double result2 = result - comision;
            Console.WriteLine($"{result2:F2}");


        }
    }
}
