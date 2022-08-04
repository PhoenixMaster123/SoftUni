using System;

namespace T2___Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            double luggage = double.Parse(Console.ReadLine());
            double kilograms = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int countluggage = int.Parse(Console.ReadLine());
            double priceluggage = 0;
            //double priceluggage = luggage / countluggage;
            if(kilograms<10)
            {
                priceluggage = luggage * 0.2;
            }
            else if(kilograms>=10&&kilograms<=20)
            {
                priceluggage = luggage * 0.5;
                
            }
            else if(kilograms>20)
            {
                priceluggage = luggage;
            }
            if (days > 30)
            {
                priceluggage = priceluggage + priceluggage * 0.1;
            }
            else if (days >= 7 && days <= 30)
            {
                priceluggage = priceluggage + priceluggage * 0.15;
            }
            else
            {
                priceluggage = priceluggage + priceluggage * 0.4;
            }
            double result = priceluggage * countluggage;
            Console.WriteLine($"The total price of bags is: {result:F2} lv.");
        }
    }
}
