using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Border_Control
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command;
            Dictionary<string, string> map = new Dictionary<string, string>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] parts = command.Split(" ");
                string name = parts[0];

                if(parts.Length == 2)
                {
                    string id = parts[1];
                    IRobots robot = new Robot(name,id);
                    map.Add(robot.Model, robot.Id);
                }
                else
                {
                    
                    int age = int.Parse(parts[1]);
                    string id = parts[2];
                    ICitizens citizen = new Citizen(name, age, id);
                    map.Add(citizen.Name, citizen.Id);
                }

            }
            string number = Console.ReadLine();

            foreach(var num in map.Where(x=> x.Value.EndsWith(number)))
            {
               
                    Console.WriteLine(num.Value);
                
            }
        }
    }
}
