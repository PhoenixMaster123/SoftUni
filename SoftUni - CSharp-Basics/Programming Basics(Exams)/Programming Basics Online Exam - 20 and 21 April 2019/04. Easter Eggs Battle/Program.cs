using System;

namespace _04._Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstCompetotor = int.Parse(Console.ReadLine());
            int secondCompetotor = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string winer = command;
                if (firstCompetotor <= 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {secondCompetotor} eggs left.");
                    break;
                }
                else if (secondCompetotor <= 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {firstCompetotor} eggs left.");
                    break;
                }
                if (winer == "one")
                {
                    secondCompetotor--;
                }
                else if (winer == "two")
                {
                    firstCompetotor--;
                }


            }
            if (firstCompetotor <= 0 || secondCompetotor <= 0) 
            {

            }
            else
            {
                Console.WriteLine($"Player one has {firstCompetotor} eggs left.");
                Console.WriteLine($"Player two has {secondCompetotor} eggs left.");
            }
           
        }
    }
}
