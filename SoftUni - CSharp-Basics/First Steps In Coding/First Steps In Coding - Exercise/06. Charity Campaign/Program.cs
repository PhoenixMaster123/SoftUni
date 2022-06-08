using System;

namespace _15._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int personal = int.Parse(Console.ReadLine());
            int countcakes = int.Parse(Console.ReadLine());
            int gofretscount = int.Parse(Console.ReadLine());
            int pancakescount = int.Parse(Console.ReadLine());          

            double pricecakes = countcakes * 45;
            double pricegofrets = gofretscount * 5.80;
            double pricepancakes = pancakescount * 3.20;

            double result = (pricecakes + pricegofrets + pricepancakes) * personal;
            result = result * days;
            result = result - result * 0.125;
            Console.WriteLine(result);



        }
    }
}
