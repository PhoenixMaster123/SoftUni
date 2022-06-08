using System;

namespace _12._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            double yearpercent = double.Parse(Console.ReadLine());
            //double result = amount + month*((amount * yearpercent) / 12);
            double result = amount * (yearpercent/100);
            double resultformonth = result / 12;
            double end = amount + (month * resultformonth);
            Console.WriteLine(end);
        }
    }
}
