using System;

namespace Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            
             int moneyneeded = int.Parse(Console.ReadLine());
             string command = "";
             double paymentcash = 0;
             double paymentcard = 0;
             double payment = 0;
             int cash = 0;
             int card = 0;
             while(true)
             {
                 command = Console.ReadLine();
                 if (command == "End")
                 {
                     break;
                 }
                 else
                 {
                     int moneycard = int.Parse(command);
                     int moneycash = int.Parse(Console.ReadLine());
                     if (moneycard >= 100)
                     {
                         Console.WriteLine("Error in transaction!");
                     }
                     if(moneycash <= 10)
                     {
                         Console.WriteLine("Error in transaction!");
                     }
                     if (moneycard < 100)
                     {
                         paymentcard += moneycard;
                         card++;
                         Console.WriteLine("Product sold!");
                     }
                     if (moneycash >= 10)
                     {
                         paymentcash += moneycash;
                         cash++;
                         Console.WriteLine("Product sold!");
                     }

                 }

             }
             payment = paymentcard + paymentcash;
             if (payment >= moneyneeded) 
             {
                 paymentcash /= cash;
                 paymentcard /= card;
                 Console.WriteLine($"Average CS: {paymentcash:F2}");
                 Console.WriteLine($"Average CS: {paymentcard:F2}");
             }
             else
             {
                 Console.WriteLine("Failed to collect required money for charity.");
             }
        }
    }
}
