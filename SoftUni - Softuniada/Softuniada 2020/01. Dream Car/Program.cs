using System;

namespace Softuniada_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            double startsalary = double.Parse(Console.ReadLine());
            double costs = double.Parse(Console.ReadLine());
            double newsolary = double.Parse(Console.ReadLine());
            double carcosts = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            double sum = startsalary;


            for (int i = 1; i < month; i++)
            {
                
                startsalary += newsolary;
                sum += startsalary;

            }
            costs *= month;
            double total = sum - costs;
            if(total>=carcosts)
            {
                Console.WriteLine("Have a nice ride!");
            }
            else
            {
                Console.WriteLine("Work harder!");
            }
        }
    }
}
