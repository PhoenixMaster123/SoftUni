using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyforvacation = double.Parse(Console.ReadLine());
            double ownmoney = double.Parse(Console.ReadLine());
            int days = 0;
            int spend = 0;
            while (spend != 5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                days++;
                if (command == "save")
                {
                    ownmoney += money;
                    spend = 0;
                }
                else if (command == "spend")
                {
                    spend++;
                    if (money > ownmoney) 
                   {
                        ownmoney = 0;
                   }
                    else
                    {
                        ownmoney -= money;
                    }
                   
                }
                if (ownmoney >= moneyforvacation)
                {                 
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }
            }
            if(spend==5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(days);
            }
                
           }
        }
    }

