using System;
using System.Linq;

namespace Exercise___06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();         
            Console.WriteLine(PrintMidString(word));
        }
        static string PrintMidString(string input)
        {
            int len = input.Length;
            string result = "";

            if (len % 2 == 1)
            {
                result = input[input.Length / 2].ToString();
            }
            else
            {
                result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
            }

            return result;
        }
    }
    }

