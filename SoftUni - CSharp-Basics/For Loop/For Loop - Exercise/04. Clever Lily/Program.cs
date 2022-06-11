using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int pricetoy = int.Parse(Console.ReadLine());

            int toys = 0;
            int money = 0;
            int allmoney = 0;

            for(int i=1;i<=age;i++)
            {
                money += 5;
                if (i % 2 == 0)
                {
                    allmoney += money - 1;
                }
                else
                {
                    toys++;
                }
            }
            allmoney += toys * pricetoy;
            if(allmoney>=price)
            {
                Console.WriteLine($"Yes! {allmoney - price:F2}");
            }
            else
            {
                Console.WriteLine($"No! {price - allmoney:F2}");
            }
        }
    }
}
