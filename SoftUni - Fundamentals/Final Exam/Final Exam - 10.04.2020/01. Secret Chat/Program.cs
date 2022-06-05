using System;
using System.Linq;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Reveal")
            {
                string[] token = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string action = token[0];
                if (action == "InsertSpace")
                {
                    int index = int.Parse(token[1]);
                    message = message.Insert(index, " ");

                }
                else if (action == "Reverse")
                {
                    string substring = token[1];
                    if (message.Contains(substring))
                    {
                        int wordIndex = message.IndexOf(substring); // it finds first index
                        message = message.Remove(wordIndex, substring.Length);
                        message = message + string.Join("", substring.Reverse());
                    }
                    else
                    {
                        Console.WriteLine("error");
                        command = Console.ReadLine();
                        continue;
                    }
                }
                else if (action == "ChangeAll")
                {
                    string substring = token[1];
                    string replacementText = token[2];
                    message = message.Replace(substring, replacementText);

                }
                Console.WriteLine(message);
                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
