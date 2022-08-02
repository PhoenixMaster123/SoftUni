using System;

namespace _04._Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());            
            string command;
            double total = 0;
            double money = 0;
            while ((command = Console.ReadLine()) != "Party!")
            {
                string nameOfCoctail = command;
                int countCoctails = int.Parse(Console.ReadLine());

                 total = nameOfCoctail.Length * countCoctails;
                 double num = total % 10;
                if (num % 2 != 0)
                {
                    total -= total * 0.25;
                    money += total;
                }
                else
                {
                    money += total;
                }
                if (money >= income)
                {
                    break;
                }
            }
            
            if(money < income)
            {
                double result = income - money;
                Console.WriteLine($"We need {result:F2} leva more.");
                Console.WriteLine($"Club income - {money:F2} leva.");
            }
            else
            {
                Console.WriteLine("Target acquired.");
                Console.WriteLine($"Club income - {money:F2} leva.");
            }
        }
    }
}
