using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string balance = Console.ReadLine();
            double sum = 0;
            while (balance != "NoMoreMoney")
            {
                double money = double.Parse(balance);               
                if (money >= 0)
                {
                    Console.WriteLine($"Increase: {money:F2}");
                    sum += money;
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:F2}");
                

            
        }
    }
}
