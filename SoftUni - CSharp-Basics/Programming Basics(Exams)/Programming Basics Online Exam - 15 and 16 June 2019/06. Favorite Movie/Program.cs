using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Favorite_Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            int points = 0;
            int movieCount = 0;
            Dictionary<string, int> map = new Dictionary<string, int>();
            while((command = Console.ReadLine())!="STOP")
            {
                string movies = command;
                movieCount++;
                if (movieCount == 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;   
                }
                foreach (char currentChar in movies)
                {
                    if (char.IsUpper(currentChar))
                    {
                        points += currentChar - movies.Length;
                    }
                    else if (char.IsLower(currentChar))
                    {
                        points += currentChar -  2 * movies.Length ;
                    }
                    else
                    {
                        points += currentChar;
                    }     
                }
                map.Add(movies, points);
                points = 0;
            }            
             foreach(var dictionary in map.OrderByDescending(x=>x.Value))
             {
                    Console.WriteLine($"The best movie for you is {dictionary.Key} with {dictionary.Value} ASCII sum.");
                    break;
             }
            
        }
    }
}
