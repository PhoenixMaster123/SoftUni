using System;
using System.Collections.Generic;

namespace _05._Filter_By_Age___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>();

            for (int i = 0; i < input; i++)
            {
                string[] token = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (!people.ContainsKey(token[0]))
                {
                    people[token[0]] = int.Parse(token[1]);
                }
            }

            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            Func<int, bool> filter;
            if (condition == "younger")
            {
                filter = x => x < age;
            }
            else
            {
                filter = x => x >= age;
            }

            if (format == "age")
            {
                Print(people, filter, (key, value) => value.ToString());
            }
            else if (format == "name")
            {
                Print(people, filter, (key, value) => key);
            }
            else
            {
                Print(people, filter, (key, value) => key + " - " + value);
            }
        }
        static void Print(Dictionary<string, int> people, Func<int, bool> filter, Func<string, int, string> print)
        {
            foreach (var kvp in people)
            {
                var name = kvp.Key;
                var age = kvp.Value;

                if (filter(age))
                {
                    Console.WriteLine(print(name, age));
                }
            }
        }
    }
}
