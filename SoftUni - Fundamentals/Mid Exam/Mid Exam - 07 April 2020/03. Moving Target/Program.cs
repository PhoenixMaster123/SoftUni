using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmd = command.Split(' ').ToArray();
                string action = cmd[0];

                int index = int.Parse(cmd[1]);
                int value = int.Parse(cmd[2]);


                if (action == "Shoot")
                {
                    if (index >= 0 && index <= targets.Count - 1)
                    {
                        ShootTarget(index, value, targets);
                    }
                }
                else if (action == "Strike")
                {
                    if (index - value >= 0 && index + value < targets.Count - 1)
                    {
                        StrikeTarget(index, value, targets);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
                else if (action == "Add")
                {

                    if (index < targets.Count && index >= 0)
                    {
                        AddTarget(index, value, targets);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join('|', targets));


        }
        static List<int> ShootTarget(int index, int value, List<int> targets)
        {
            if (targets[index] > value)
            {
                targets[index] = targets[index] - value;
            }
            else if (targets[index] <= value)
            {
                targets.RemoveAt(index);
            }

            return targets;
        }


        static List<int> StrikeTarget(int index, int value, List<int> targets)
        {
            int start = index - value;
            int final = index + value;

            for (int i = start; i <= final; i++)
            {
                targets.RemoveAt(start);
            }

            return targets;
        }

        static List<int> AddTarget(int index, int value, List<int> targets)
        {
            targets.Insert(index, value);

            return targets;
        }
    }
}
