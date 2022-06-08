using System;

namespace _16._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double erdberreprice = double.Parse(Console.ReadLine());
            double banans = double.Parse(Console.ReadLine());
            double oranges = double.Parse(Console.ReadLine());
            double berry = double.Parse(Console.ReadLine());
            double strawberry = double.Parse(Console.ReadLine());

           double  berryprice = erdberreprice / 2;
           double orangesprice = berryprice - 0.4* berryprice ;
            double banansprice = berryprice - 0.8 * berryprice ;

            berryprice = berryprice * berry;
            orangesprice = oranges * orangesprice;
            banansprice = banansprice * banans;
            strawberry = strawberry * erdberreprice;
            double result = (berryprice + orangesprice + banansprice + strawberry);
            Console.WriteLine(Math.Round(result, 2));





        }
    }
}
