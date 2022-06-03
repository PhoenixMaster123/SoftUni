using System;

namespace _01._Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////// First Variant ///////////////////////////////////////////////////////
            //double result = 0;
            //double taxes = 0;
            //string command = string.Empty;
            //while (true)
            //{
            //    command = Console.ReadLine();
            //    if (command == "special" || command == "regular")
            //    {
            //        break;
            //    }
            //    double prices = (double.Parse(command));
            //    if (prices < 0)
            //    {
            //        Console.WriteLine("Invalid price!");
            //    }
            //    else
            //    {
            //        taxes += prices * 0.20;
            //        result += prices;
            //    }


            //}

            //if (command == "special" && result == 0)
            //{
            //    Console.WriteLine("Invalid order!");
            //}
            //else if (command == "special")
            //{
            //    Console.WriteLine($"Congratulations you've just bought a new computer!");
            //    Console.WriteLine($"Price without taxes: {result:F2}$");
            //    Console.WriteLine($"Taxes: {taxes:F2}$");
            //    Console.WriteLine("-----------");
            //    result += taxes;
            //    result = result - result * 0.10;
            //    Console.WriteLine($"Total price: {result:F2}$");
            //}
            //else if (command == "regular" && result == 0)
            //{
            //    Console.WriteLine("Invalid order!");
            //}
            //else
            //{
            //    Console.WriteLine($"Congratulations you've just bought a new computer!");
            //    Console.WriteLine($"Price without taxes: {result:F2}$");
            //    Console.WriteLine($"Taxes: {taxes:F2}$");
            //    Console.WriteLine("-----------");
            //    result += taxes;
            //    Console.WriteLine($"Total price: {result:F2}$");
            //}

            ///////////////////////////////////////////////////////////////////////////// Second Variant //////////////////////////////////////////////
            string command = Console.ReadLine();
            decimal totalPriceWithNoTaxes = 0;
            while (command != "regular" && command != "special")
            {
                decimal price = decimal.Parse(command);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }
                totalPriceWithNoTaxes += price;

                command = Console.ReadLine();
            }
            if (totalPriceWithNoTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
               // Environment.Exit(0);
                return;
            }
            decimal taxes = totalPriceWithNoTaxes * 0.2m;
            if (command == "special")
            {
                decimal totalWithTaxes = totalPriceWithNoTaxes + taxes;
                decimal totalPriceWithDiscount = totalWithTaxes * 0.9m;
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWithNoTaxes:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPriceWithDiscount:F2}$");
            }
            else
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWithNoTaxes:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {(totalPriceWithNoTaxes+taxes):F2}$");
            }
        }
    }
}
