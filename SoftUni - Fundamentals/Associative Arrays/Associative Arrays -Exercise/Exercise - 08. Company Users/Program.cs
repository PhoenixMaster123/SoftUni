namespace _08._Company_Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] courseArgs = command
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();                        
                string companyName = courseArgs[0];
                string employeeID = courseArgs[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }

                if (!companies[companyName].Contains(employeeID))
                {
                    companies[companyName].Add(employeeID);
                }

                command = Console.ReadLine();
            }


            foreach (var kvp in companies)
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var employeeID in kvp.Value)
                {
                    Console.WriteLine($"-- {employeeID}");
                }
            }
        }
    }
}