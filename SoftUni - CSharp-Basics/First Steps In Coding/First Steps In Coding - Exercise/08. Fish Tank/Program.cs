using System;

namespace _17._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double high = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double result = lenght * width * high;
            result = result * 0.001;
            percent = percent * 0.01;
            result = result * (1 - percent);
            Console.WriteLine(result);
        }
    }
}
