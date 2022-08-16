using System;

namespace _04._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capasity = int.Parse(Console.ReadLine());
            string command;
            double income = 0;
            int allPeople = 0;
            while((command = Console.ReadLine())!= "Movie time!")
            {
                int people = int.Parse(command);
                allPeople += people;
                
                if (allPeople > capasity)
                {
                    Console.WriteLine("The cinema is full.");
                    Console.WriteLine($"Cinema income - {income} lv.");
                    break;
                }
                income += people * 5;
                if (people % 3 == 0)
                {
                    income -= 5;
                }
               

            }
            if(allPeople <= capasity)
            {
                capasity -= allPeople;
                Console.WriteLine($"There are {capasity} seats left in the cinema.");
                Console.WriteLine($"Cinema income - {income} lv.");
            }
            
           
        }
    }
}
