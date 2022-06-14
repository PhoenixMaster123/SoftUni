using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /////////////////////////////////////////////////////////////////// First Variant - slow! //////////////////////
            //int namesCount = int.Parse(Console.ReadLine());
            // List<string> listNames = new List<string>();

            // for (int i = 0; i < namesCount; i++)
            // {
            //     string name = Console.ReadLine();
            //     if(!listNames.Contains(name))
            //     {
            //         listNames.Add(name);
            //     }
            //     else
            //     {
            //         continue;
            //     }
            // }
            // foreach (string name in listNames)
            // {
            //     Console.WriteLine(name);
            // }

            /////////////////////////////////////////////////////////////////// Second Variant - fast! //////////////////////
            
            int namesCount = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < namesCount; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);

            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
