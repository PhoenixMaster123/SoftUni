using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> namesList = new List<string>();
            int num = int.Parse(Console.ReadLine());          
            for (int i = 0; i < num; i++)
            {
                string[] commandArgument = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = commandArgument[0];


                if (commandArgument.Length == 3)
                {
                    if (namesList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    
                        namesList.Add(name);
                    

                }
                else if (commandArgument.Length == 4)
                {
                    if (!namesList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }
                   
                        namesList.Remove(name);
                    
                }
               
              
            } // End for loop


            //PrintNames(namesList); // First Variant
            Console.WriteLine(string.Join(Environment.NewLine, namesList)); // Second Variant
            static void PrintNames(List<string> items)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine(items[i]);
                }
            }
        }

    }
}

