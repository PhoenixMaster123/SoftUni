using System;

namespace _03._Fitness_Card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double price = 0;
            if(gender.Equals('m'))
            {
                if (sport.Equals("Gym"))
                {
                    price = 42;
                    if(age <= 19)
                    {
                        price -= price * 0.20;
                    }
                    if (money >= price)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        money -= price;
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(money):F2} more.");
                    }
                }
                else if (sport.Equals("Boxing"))
                {
                    price = 41;
                    if (age <= 19)
                    {
                        price -= price * 0.20;
                    }
                    if (money >= price)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        money -= price;
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(money):F2} more.");
                    }
                }
                else if (sport.Equals("Yoga"))
                {
                    price = 45;
                    if (age <= 19)
                    {
                        price -= price * 0.20;
                    }
                    if (money >= price)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        money -= price;
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(money):F2} more.");
                    }
                }
                else if (sport.Equals("Zumba"))
                {
                    price = 34;
                    if (age <= 19)
                    {
                        price -= price * 0.20;
                    }
                    if (money >= price)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        money -= price;
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(money):F2} more.");
                    }
                }
                else if (sport.Equals("Dances"))
                {
                    price = 51;
                    if (age <= 19)
                    {
                        price -= price * 0.20;
                    }
                    if (money >= price)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        money -= price;
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(money):F2} more.");
                    }
                }
                else if (sport.Equals("Pilates"))
                {
                    price = 39;
                    if (age <= 19)
                    {
                        price -= price * 0.20;
                    }
                    if (money >= price)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        money -= price;
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(money):F2} more.");
                    }
                }
            }
            else
            {
                if (sport.Equals("Gym"))
                {
                    price = 35;
                    if (age <= 19)
                    {
                        price -= price * 0.20;
                    }
                    if (money >= price)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        money -= price;
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(money):F2} more.");
                    }
                }
                else if (sport.Equals("Boxing"))
                {
                    price = 37;
                    if (age <= 19)
                    {
                        price -= price * 0.20;
                    }
                    if (money >= price)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        money -= price;
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(money):F2} more.");
                    }
                }
                else if (sport.Equals("Yoga"))
                {
                    price = 42;
                    if (age <= 19)
                    {
                        price -= price * 0.20;
                    }
                    if (money >= price)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        money -= price;
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(money):F2} more.");
                    }
                }
                else if (sport.Equals("Zumba"))
                {
                    price = 31;
                    if (age <= 19)
                    {
                        price -= price * 0.20;
                    }
                    if (money >= price)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        money -= price;
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(money):F2} more.");
                    }
                }
                else if (sport.Equals("Dances"))
                {
                    price = 53;
                    if (age <= 19)
                    {
                        price -= price * 0.20;
                    }
                    if (money >= price)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        money -= price;
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(money):F2} more.");
                    }
                }
                else if (sport.Equals("Pilates"))
                {
                    price = 37;
                    if (age <= 19)
                    {
                        price -= price * 0.20;
                    }
                    if (money >= price)
                    {
                        Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                    }
                    else
                    {
                        money -= price;
                        Console.WriteLine($"You don't have enough money! You need ${Math.Abs(money):F2} more.");
                    }
                }
            }
        }
    }
}
