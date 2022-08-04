using System;

namespace T1___Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string company = Console.ReadLine();
            int eldern = int.Parse(Console.ReadLine());
            int kids = int.Parse(Console.ReadLine());
            double neteldernprice = double.Parse(Console.ReadLine());
            double served = double.Parse(Console.ReadLine());

            double kidsprice = neteldernprice - neteldernprice * 0.7;
            double elderprice = neteldernprice + served;

            double allkidsprice = kidsprice + served;

            double result = (kids * allkidsprice) + (eldern * elderprice);

            double profit = result * 0.2;
            Console.WriteLine($"The profit of your agency from {company} tickets is {profit:F2} lv.");

       
        }
    }
}
