using System;
using System.Linq;
using System.Text;

namespace Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawPassword = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] splitted = command.Split(' ');
                string action = splitted[0];

                if (action == "TakeOdd")
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 1; i < rawPassword.Length; i += 2)
                    {
                        sb.Append(rawPassword[i]);
                    }
                    rawPassword = sb.ToString();
                    Console.WriteLine(rawPassword);
                }
                else if (action == "Cut")
                {
                    int startIndex = int.Parse(splitted[1]);
                    int lenght = int.Parse(splitted[2]);
                    int test = startIndex + lenght;

                    if (test <= rawPassword.Length)
                    {
                        string substr = rawPassword.Substring(startIndex, lenght);
                        int index = rawPassword.IndexOf(substr);
                        rawPassword = rawPassword.Remove(index, substr.Length);
                        Console.WriteLine(rawPassword);
                    }

                }
                else if (action == "Substitute")
                {
                    string chReplace = splitted[1];
                    string newChar = splitted[2];

                    if (rawPassword.Contains(chReplace))
                    {
                        rawPassword = rawPassword.Replace(chReplace, newChar);
                        Console.WriteLine(rawPassword);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {rawPassword}");
        }
    }
}