using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        /////////////////////////// My Variant /////////////////////////////////////////////
        //static void Main(string[] args)
        //{
        //    int a = int.Parse(Console.ReadLine());
        //    int b = int.Parse(Console.ReadLine());
        //    PrintArea(a, b);
        //}
        //static void PrintArea(int a, int b)
        //{
        //    double area = 0;
        //    area = a * b;
        //    Console.WriteLine(area);
        //    return;
        //}
        ///////////////////////// Teachers Variant //////////////////////////////////////
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetRectangleArea(width, height);
            Console.WriteLine(area);
        }
        static double GetRectangleArea(double width, double height)
        {         
            double area = width * height;
            return area;
        }
    }
}
