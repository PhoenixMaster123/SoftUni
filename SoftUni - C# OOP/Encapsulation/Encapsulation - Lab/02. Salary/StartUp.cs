using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
          
                int humansCount = int.Parse(Console.ReadLine());

                List<Person> persons = new List<Person>();

                for (int i = 0; i < humansCount; i++)

                {

                    string[] lines = Console.ReadLine().Split();

                    Person person = new Person(lines[0], lines[1], int.Parse(lines[2]), decimal.Parse(lines[3]));

                    persons.Add(person);

                }

                decimal parcentage = decimal.Parse(Console.ReadLine());
                persons.ForEach(p => p.IncreaseSalary(parcentage));
                persons.ForEach(p => Console.WriteLine(p.ToString()));

            }
          
           
        }
    }

