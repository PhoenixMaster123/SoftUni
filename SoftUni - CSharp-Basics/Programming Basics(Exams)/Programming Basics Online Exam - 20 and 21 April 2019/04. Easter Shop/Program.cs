using System;

namespace _04._Easter_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int allEggs = int.Parse(Console.ReadLine());
            string command;
            int allSellEggs = 0;
            while ((command = Console.ReadLine()) != "Close") 
            {
                string action = command;
                int eggs = int.Parse(Console.ReadLine());
                
                if (action == "Fill")
                {
                    allEggs += eggs;
                }
                else if(action == "Buy")
                {
                    allEggs -= eggs;
                    allSellEggs += eggs;
                    if (allEggs < 0)
                    {
                        allEggs += eggs;
                        Console.WriteLine("Not enough eggs in store!");
                        Console.WriteLine($"You can buy only {allEggs}.");
                        break;
                    }
                }
               
                
            }
            if (command == "Close")
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{allSellEggs} eggs sold.");
               
            }
        }
    }
}
