using System;
using System.Linq;

namespace Exercise___02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<int> numbers = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            string command = Console.ReadLine();
            while(command != "end")
            {
                
                string[] commands = command.Split().ToArray();
                string checkForAdd = commands[0];
                if (checkForAdd == "Delete")
                {
                    int deleteNumber = int.Parse(commands[1]);
                    numbers.Remove(deleteNumber);
                    if(numbers.Contains(deleteNumber))
                    {
                        numbers.Remove(deleteNumber);
                    }    
                }
                else if(checkForAdd == "Insert")
                {
                    int number = int.Parse(commands[1]);
                    int second = int.Parse(commands[2]);
                    numbers.Insert(second, number);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
