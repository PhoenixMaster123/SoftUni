using System;

namespace _06._Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mackerel = double.Parse(Console.ReadLine());
            double sprat = double.Parse(Console.ReadLine());
            double bonito = double.Parse(Console.ReadLine());
            double scad = double.Parse(Console.ReadLine());
            int mussels = int.Parse(Console.ReadLine());



            double mackerelprice = mackerel + mackerel * 0.6;
            double bonitopriceresult = mackerelprice * bonito;
            double spratprice = sprat + 0.8 * sprat;
            double scadpriceresult = scad * spratprice;
            double musselsprice = mussels * 7.50;

            double result = bonitopriceresult + scadpriceresult + musselsprice;
            Console.WriteLine("{0:0.00}", result);

        }
    }
}
