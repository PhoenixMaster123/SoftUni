using System;

namespace Exercise___05._Add_and_Subtract
{
    internal class Program
    {
        /////////////////////////////////////////////// First Variant - My ///////////////////////////////
        //static void Main(string[] args)
        //{
        //    int num1 = int.Parse(Console.ReadLine());
        //    int num2 = int.Parse(Console.ReadLine());
        //    int num3 = int.Parse(Console.ReadLine());

        //    Console.WriteLine(SumFirstAndSecond(num1,num2,num3));
        //}
        //static int SumFirstAndSecond(int num1, int num2, int num3)
        //{
        //    int result = 0;
        //    result = (num1 + num2)-num3;
        //    return result;
        //}
        ////////////////////////////////////////////////////// Second - My /////////////////////////////////////////////


        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int result = SumFirstAndSecond(num1, num2);        
            Console.WriteLine(Substract(result, num3));
        }
        static int SumFirstAndSecond(int num1, int num2)
        {
            int result = 0;
            result = num1 + num2;
            return result;

        }
        static int Substract(int result, int num3)
        {
            result -= num3;
            return result;
        }
    }
}
