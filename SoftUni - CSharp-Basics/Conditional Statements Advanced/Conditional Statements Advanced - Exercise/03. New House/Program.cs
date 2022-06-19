using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double roses = 5.00;
            double dahlias = 3.80;
            double tulips = 2.80;
            double narcissus = 3.00;
            double gladiolus = 2.50;
            double price = 0;

            switch(flowers)
            {
                case "Roses":
                    if(count>80)
                    {
                        price -= count * roses * 0.10;
                    }
                    price += count * roses;
                    break;
                case "Dahlias":
                    if (count > 90)
                    {
                        price -= count * dahlias * 0.15;
                    }
                    price += count * dahlias;
                    break;
                case "Tulips":
                    if (count > 80)
                    {
                        price -= count * tulips * 0.15;
                    }
                    price += count * tulips;
                    break;
                case "Narcissus":
                    if (count < 120)
                    {
                        price += count * narcissus * 0.15;
                    }
                    price += count * narcissus;
                    break;
                case "Gladiolus":
                    if (count < 80)
                    {
                        price += count * gladiolus * 0.20;
                    }
                    price += count * gladiolus;
                    break;


            }
            if(budget>=price)
            {
                double moneyLeft = budget - price;
                Console.WriteLine($"Hey, you have a great garden with {count} {flowers} and {moneyLeft:F2} leva left.");
            }
            else
            {
                double moneyLeft = price - budget;
                Console.WriteLine($"Not enough money, you need {moneyLeft:F2} leva more.");
            }


            /*if (count > 80 && flowers == "Roses")
            {
                double result = count * roses;
                price = result - result * 0.10;
            }*/
        }
    }
}
