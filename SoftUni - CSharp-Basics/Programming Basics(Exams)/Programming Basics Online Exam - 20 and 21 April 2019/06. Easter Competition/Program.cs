using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Easter_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countCosunats = int.Parse(Console.ReadLine());
            string note = string.Empty;
            string currentChef = string.Empty;

            int maxPoints = int.MinValue;

            for (int i = 1; i <= countCosunats; i++)
            {
                string nameChef = Console.ReadLine();
                note = Console.ReadLine();
                int points = 0;

                while (note != "Stop")
                {
                    int grade = int.Parse(note);

                    if (grade <= 0 || grade > 10)
                    {
                        note = Console.ReadLine();
                        continue;
                    }

                    points += grade;
                    note = Console.ReadLine();
                }

                Console.WriteLine($"{nameChef} has {points} points.");

                if (points > maxPoints)
                {
                    maxPoints = points;
                    currentChef = nameChef;
                    Console.WriteLine($"{currentChef} is the new number 1!");
                }
            }

            Console.WriteLine($"{currentChef} won competition with {maxPoints} points!");
        }
    }
}

