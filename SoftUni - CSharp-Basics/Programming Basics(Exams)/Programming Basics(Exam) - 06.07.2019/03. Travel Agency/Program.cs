using System;

namespace _03._Travel_Agency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            if (city != "Bansko" && city != "Borovets" && city != "Varna" && city != "Burgas")
            {
                Console.WriteLine("Invalid input!");
                Environment.Exit(0);
            }
            string typeOfpacket = Console.ReadLine();
            if (typeOfpacket != "noEquipment" && typeOfpacket != "withEquipment" && typeOfpacket != "noBreakfast" && typeOfpacket != "withBreakfast")
            {
                Console.WriteLine("Invalid input!");
                Environment.Exit(0);
            }
            string vipOrNot = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            if (days < 1)
            {             
                Console.WriteLine("Days must be positive number!");
                Environment.Exit(0);

            }
            double total = 0;
            if (city == "Bansko" || city == "Borovets")
            {
                if (typeOfpacket == "noEquipment")
                {
                    total += 80;
                    if (vipOrNot == "yes")
                    {
                        total -= total * 0.05;
                    }
                }
                else if (typeOfpacket == "withEquipment")
                {
                    total += 100;
                    if (vipOrNot == "yes")
                    {
                        total -= total * 0.10;
                    }
                }



            }
            else if (city == "Varna" || city == "Burgas")
            {
                if (typeOfpacket == "noBreakfast")
                {
                    total += 100;
                    if (vipOrNot == "yes")
                    {
                        total -= total * 0.07;
                    }

                }
                else if (typeOfpacket == "withBreakfast")
                {
                    total += 130;
                    if (vipOrNot == "yes")
                    {
                        total -= total * 0.12;
                    }
                }

            }
            if (days > 7)
            {
                total *= days-1;
                Console.WriteLine($"The price is {total:F2}lv! Have a nice time!");
            }
            else
            {
                total *= days;
                Console.WriteLine($"The price is {total:F2}lv! Have a nice time!");
            }
        }
    }
}
