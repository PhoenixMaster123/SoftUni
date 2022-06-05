using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTextEditor
{
    public class StartUp
    {
        static void Main()
        {
            int countOperations = int.Parse(Console.ReadLine());

            string text = string.Empty;

            Stack<string> latestVersion = new Stack<string>();

            for (int i = 0; i < countOperations; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                string action = command[0];

                if (action == "1")
                {
                    latestVersion.Push(text);
                    string append = command[1];
                    text = text + append;
                }
                else if (action == "2")
                {
                    latestVersion.Push(text);
                    int count = int.Parse(command[1]);
                    int startIndex = text.Length - count;
                    text = text.Remove(startIndex);
                }
                else if (action == "3")
                {
                    int operation = int.Parse(command[1]);

                    Console.WriteLine(text[operation - 1]);
                }
                else if (action == "4")
                {
                    string update = latestVersion.Pop();
                    text = update;
                }
            }
        }
    }
}