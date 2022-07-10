using System;

namespace _03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////////// First Variant //////////////////////////////////////
            double eps = 0.000001;
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double result = Math.Abs(num1 - num2);
            if(result < eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            /////////////////////////////////////////////////////////////////////// Second Variant //////////////////////////////////////
            //bool isEqual = Math.Abs(num1 - num2) < eps;

            //if (isEqual)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

        }
    }
}
