using System;

namespace _03._Coffee_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfTrink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int countTrink = int.Parse(Console.ReadLine());
            double total = 0;
            if(typeOfTrink == "Espresso")
            {
                if(sugar == "Without")
                {
                    total += 0.90 * countTrink;
                    double discount = total * 0.35;
                    total -= discount;
                }
                else if(sugar == "Normal")
                {
                    total += 1 * countTrink;

                }
                else if(sugar == "Extra")
                {
                    total += 1.20 * countTrink;
                }
                if (countTrink >= 5)
                {
                    double discount = total * 0.25;
                    total -= discount;
                }
            }
            else if(typeOfTrink == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    total += 1 * countTrink;
                    double discount = total * 0.35;
                    total -= discount;
                }
                else if (sugar == "Normal")
                {
                    total += 1.20 * countTrink;
                }
                else if (sugar == "Extra")
                {
                    total += 1.60 * countTrink;
                }
            }
            else if (typeOfTrink == "Tea")
            {
                if (sugar == "Without")
                {
                    total += 0.50 * countTrink;
                    double discount = total * 0.35;
                    total -= discount;
                }
                else if (sugar == "Normal")
                {
                    total += 0.60 * countTrink;
                }
                else if (sugar == "Extra")
                {
                    total += 0.70 * countTrink;
                }
            }
            if(total > 15)
            {
                double discount = total * 0.20;
                total -= discount;
                Console.WriteLine($"You bought {countTrink} cups of {typeOfTrink} for {total:F2} lv.");
            }
            else
            {
                Console.WriteLine($"You bought {countTrink} cups of {typeOfTrink} for {total:F2} lv.");
            }
        }
    }
}
