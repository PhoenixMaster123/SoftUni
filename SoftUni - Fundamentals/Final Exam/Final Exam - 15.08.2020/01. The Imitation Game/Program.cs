using System;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Decode")
            {
                string[] token = command.Split('|');
                string action = token[0];
                if (action == "Move")
                {
                    int number = int.Parse(token[1]);
                    string reverse = word.Substring(0, number);
                    string secondReverse = word.Substring(number);
                    word = secondReverse + reverse;
                }
                else if (action == "Insert")
                {
                    int add = int.Parse(token[1]);
                    string letter = token[2];
                    word = word.Insert(add, letter);
                }
                else if (action == "ChangeAll")
                {
                    char letter1 = char.Parse(token[1]);
                    char letter2 = char.Parse(token[2]);
                    word = word.Replace(letter1, letter2);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {word}");
        }
    }
}
