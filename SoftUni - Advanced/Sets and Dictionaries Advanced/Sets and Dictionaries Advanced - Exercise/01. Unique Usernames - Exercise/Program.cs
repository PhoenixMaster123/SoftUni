using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int input = int.Parse(Console.ReadLine());
            HashSet<string> usernames = new HashSet<string>();
            for (int i = 0; i < input; i++)
            {
                string persons = Console.ReadLine();
                usernames.Add(persons);

            }
            foreach(string name in usernames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
