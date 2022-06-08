using System;

namespace _10._USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double bg = usd * 1.79549;
            Console.WriteLine(bg);
        }
    }
}
