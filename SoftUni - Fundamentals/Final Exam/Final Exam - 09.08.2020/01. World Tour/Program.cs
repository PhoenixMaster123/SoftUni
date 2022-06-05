using System;

namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string travel = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Travel")
            {
                string[] token = command.Split(':');
                string action = token[0];
                if (action == "Add Stop")
                {
                    int add = int.Parse(token[1]);
                    string destination = token[2];
                    travel = travel.Insert(add, destination);
                    Console.WriteLine(travel);
                }
                else if (action == "Remove Stop")
                {
                    int removeDestination = int.Parse(token[1]);
                    int removeDestination2 = int.Parse(token[2]);
                    if (removeDestination < travel.Length && removeDestination2 < travel.Length)
                    {
                        travel = travel.Remove(removeDestination, removeDestination2 - removeDestination + 1);
                    }
                    Console.WriteLine(travel);
                }
                else if (action == "Switch")
                {
                    string switchDestination = token[1];
                    string switchDestination2 = token[2];
                    travel = travel.Replace(switchDestination, switchDestination2);
                    Console.WriteLine(travel);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {travel}");
        }
    }
}
