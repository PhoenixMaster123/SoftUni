using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string command = string.Empty;
            double price;
            double total = 0;
            while (true)
            {
                string games = Console.ReadLine();
                if (games == "Game Time")
                {
                    break;
                }
                if (games != "OutFall 4" && games != "CS: OG" && games != "OutFall 4" && games != "Zplinter Zell" 
                   && games != "Honored 2" && games != "RoverWatch" && games != "RoverWatch Origins Edition")
                {
                    Console.WriteLine($"Not Found");
                }

                if (games == "OutFall 4")
                {

                    price = 39.99;
                    if (balance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        balance -= price;
                        Console.WriteLine("Bought OutFall 4");
                        total += price;
                    }

                }
                else if (games == "CS: OG")
                {

                    price = 15.99;
                    if (balance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        balance -= price;
                        Console.WriteLine("Bought CS: OG");
                        total += price;
                    }

                }
                else if (games == "Zplinter Zell")
                {

                    price = 19.99;
                    if (balance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        balance -= price;
                        Console.WriteLine("Bought Zplinter Zell");
                        total += price;
                    }

                }
                else if (games == "Honored 2")
                {

                    price = 59.99;
                    if (balance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        balance -= price;
                        Console.WriteLine("Bought Honored 2");
                        total += price;
                    }

                }
                else if (games == "RoverWatch")
                {


                    price = 29.99;
                    if (balance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        balance -= price;
                        Console.WriteLine("Bought RoverWatch");
                        total += price;
                    }

                }
                else
                {


                    price = 39.99;
                    if (balance < price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        balance -= price;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        total += price;
                    }

                }


                //switch(command)
                //{
                //    case "OutFall 4": price = 39.99; if (balance <= 0) { Console.WriteLine("Out of money"); } else { balance -= price; Console.WriteLine("Bought OutFall 4"); total += balance; } break;
                //    case "CS: OG": price = 15.99; if (balance <= 0) { Console.WriteLine("Out of money"); } else { balance -= price; Console.WriteLine("Bought CS OG"); total += balance; } break;
                //    case "Zplinter Zell": price = 19.99; if (balance <= 0) { Console.WriteLine("Out of money"); } else { balance -= price; Console.WriteLine("Bought Zplinter Zell"); total += balance; } break;
                //    case "Honored 2": price = 59.99; if (balance <= 0) { Console.WriteLine("Out of money"); } else { balance -= price; Console.WriteLine("Bought Honored 2"); total += balance; } break;
                //    case "RoverWatch": price = 29.99; if (balance <= 0) { Console.WriteLine("Out of money"); } else { balance -= price; Console.WriteLine("Bought RoverWatch"); } break;
                //    case "RoverWatch Origins Edition": price = 39.99; if (balance <= 0) { Console.WriteLine("Out of money"); } else { balance -= price; Console.WriteLine("Bought RoverWatch Origins Edition"); total += balance; } break;
                //}
                //Console.WriteLine($"Total spent: {total:F2}. Remaining: {balance:F2}");
            }
            if (balance <= 0)
            {
                Console.WriteLine("Out of money!");
            }
            else
            {
                Console.WriteLine($"Total spent: ${total:F2}. Remaining: ${balance:F2}");
            }
        }
    }
}