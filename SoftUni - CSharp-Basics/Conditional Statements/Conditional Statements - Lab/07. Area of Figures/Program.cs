using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figures = Console.ReadLine();
            if (figures == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double result = a * a;
                Console.WriteLine("{0:F3}", result);
            }
            else if (figures == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double result = a * b;
                Console.WriteLine(Math.Round(result, 3));
            }
            else if (figures == "circle")
            {
                double r = double.Parse(Console.ReadLine());              
                double result = Math.PI*r*r;
                Console.WriteLine(Math.Round(result, 3));
            }
            else if (figures== "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double result = (a * b)/2;

            }
            else { }
        }
    }
}
