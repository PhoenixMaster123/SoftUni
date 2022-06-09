using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacation = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int puppets = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
         
            double puzzelsprice = puzzels * 2.60;
            double puppetssprice = puppets * 3;
            double bearssprice = bears * 4.10;
            double minionssprice = minions * 8.20;
            double truckssprice = trucks * 2;

            int alltoys = puzzels + puppets + bears + minions + trucks;
            double priceresult = puzzelsprice + puppetssprice + bearssprice + minionssprice + truckssprice;

            if(alltoys>=50)
            {
               priceresult *= 0.75;              
            }
            
            double rent = priceresult * 0.10;
            double profit = Math.Abs(rent + vacation-priceresult);    
            
            if (priceresult>=rent+vacation)
            {
                Console.WriteLine($"Yes! {profit:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {profit:F2} lv needed.");
            }
           
            
        }
    }
}
