using System;
using System.Collections.Generic;

namespace _5.Comparing_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            while (true)
            {
                var tokens = Console.ReadLine().Split();
                if (tokens[0] == "END")
                {
                    break;
                }

                persons.Add(new Person(tokens[0], int.Parse(tokens[1]), tokens[2]));
            }

            var index = int.Parse(Console.ReadLine()) - 1;
            var equal = 0;
            var notEqual = 0;
            foreach (Person person in persons)
            {
                if (persons[index].CompareTo(person) == 0)
                {
                    equal++;
                }
                else
                {
                    notEqual++;
                }
            }

            if (equal <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equal} {notEqual} {persons.Count}");
            }
        }
    }
}
