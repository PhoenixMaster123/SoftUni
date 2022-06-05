using System;

namespace _01._Activation_Keys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Generate")
            {
                //string[] token = command.Split(">>>");
                 string[] token = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string action = token[0];

                if (action == "Contains")
                {
                    string wordToSearchFor = token[1];

                    if (rawActivationKey.Contains(wordToSearchFor))
                    {
                        Console.WriteLine($"{rawActivationKey} contains {wordToSearchFor}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (action == "Flip")
                {
                    string caseToFilp = token[1];
                    int startIndex = int.Parse(token[2]);
                    int endIndex = int.Parse(token[3]);

                    string textToFilp = rawActivationKey.Substring(startIndex, endIndex - startIndex);

                    if (caseToFilp == "Lower")
                    {
                        textToFilp = textToFilp.ToLower();
                    }
                    else
                    {
                        textToFilp = textToFilp.ToUpper();
                    }

                    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);
                    rawActivationKey = rawActivationKey.Insert(startIndex, textToFilp);

                    Console.WriteLine(rawActivationKey);
                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(token[1]);
                    int endIndex = int.Parse(token[2]);

                    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);

                    Console.WriteLine(rawActivationKey);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
