using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Birthday_Celebrations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            Dictionary<string, string> map = new Dictionary<string, string>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] parts = command.Split(" ");
                string name = parts[0];

                if(name == "Citizen")
                {
                    string nameCitizen = parts[1];
                    int age = int.Parse(parts[2]);
                    string id = parts[3];
                    string birthdate = parts[4];
                    ICitizen citizen = new Citizen(name, age, id, birthdate);
                    map.Add(nameCitizen, birthdate);
                  
                    
                }
                else if(name == "Pet")
                {
                    string petName = parts[1];
                    string birthdate = parts[2];
                    IPet pet = new Pet(petName, birthdate);
                    map.Add(petName, birthdate);
                }
                else
                {
                    string model = parts[1];
                    string id = parts[2];
                    IRobots robot = new Robot(model,id);
                   // map.Add(model,id);
                }

            }
            string number = Console.ReadLine();

            foreach (var num in map.Where(x => x.Value.EndsWith(number)))
            {

                Console.WriteLine(num.Value);

            }
        }
    }
}
