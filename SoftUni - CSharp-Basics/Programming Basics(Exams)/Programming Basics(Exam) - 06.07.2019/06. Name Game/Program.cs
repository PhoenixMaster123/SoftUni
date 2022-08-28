using System;
using System.Collections.Generic;

namespace _06._Name_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int asciiTable = 0;
            int finalScore = 0;
            string WinnerName = string.Empty; 
            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                int points = 0;
                string name = command;
                for (int i = 0; i < name.Length; i++)
                {
                    asciiTable = (int)name[i];

                    int num = int.Parse(Console.ReadLine()); 

                    if (asciiTable == num)
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }

                    if (points >= finalScore) 
                    {
                        finalScore = points;
                        WinnerName = name;
                    }
                } 
               
            }

            Console.WriteLine($"The winner is {WinnerName} with {finalScore} points!");
        }
    }
}
