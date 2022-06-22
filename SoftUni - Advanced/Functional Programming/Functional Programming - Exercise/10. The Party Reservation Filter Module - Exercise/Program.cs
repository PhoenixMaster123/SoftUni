using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._The_Party_Reservation_Filter_Module___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guest = new List<string>(Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            List<string> filter = new List<string>();
            string text = Console.ReadLine();

            while (!text.Equals("Print"))
            {
                string[] commands = text.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string action = commands[0];

                if (action.Equals("Add filter"))
                {
                    filter.Add(commands[1] + " " + commands[2]);
                }
                else if (action.Equals("Remove filter"))
                {
                    filter.Remove(commands[1] + " " + commands[2]);
                }
                text = Console.ReadLine();
            }

            foreach (string colander in filter)
            {
                string[] commands = colander.Split(' ');
                string action = commands[0];
                if (action.Equals("Starts"))
                {
                    guest = guest.Where(p => !p.StartsWith((commands[2]))).ToList();
                }
                else if (action.Equals("Ends"))
                {
                    guest = guest.Where(p => !p.EndsWith(commands[2])).ToList();
                }
                else if (action.Equals("Length"))
                {
                    guest = guest.Where(p => p.Length != int.Parse(commands[1])).ToList();
                }
                else if (action.Equals("Contains"))
                {
                    guest = guest.Where(p => !p.Contains(commands[1])).ToList();
                }
            }

            if (guest.Any())
            {
                Console.WriteLine(string.Join(" ", guest));
            }
        }
    }
}
