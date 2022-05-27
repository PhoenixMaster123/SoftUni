using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
           
            Caffee(command, count);
            
            
        }
        static void Caffee(string product, int count)
        {
            double price = 0;
            if (product == "coffee")
            {
                price = count * 1.50;
               
            }
            else if(product=="water")
            {
                price = count * 1.00;
               

            }
            else if (product == "coke")
            {
                price = count * 1.40;

            }
            else
            {
                price = count * 2.00;
               
            }
            Console.WriteLine($"{price:F2}");

            

        }
           

    }
}
