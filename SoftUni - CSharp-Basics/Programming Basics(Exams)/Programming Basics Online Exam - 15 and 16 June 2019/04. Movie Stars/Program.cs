using System;

namespace _04._Movie_Stars1
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string command;
            while ((command = Console.ReadLine()) != "ACTION")
            {
                string actor = command;
               
                if (actor.Length > 15)
                {
                    budget -= budget *= 0.20;
                    continue;
                }
                double salary = double.Parse(Console.ReadLine());
                budget -= salary;
                if (budget <= 0)
                {
                   
                    break;
                }

            }
            if (budget <= 0)
            {
                Console.WriteLine($"We need {Math.Abs(budget):F2} leva for our actors.");
               
            }
            else
            {
                Console.WriteLine($"We are left with {budget:F2} leva.");
            }
           
        }
                    
    }
}
