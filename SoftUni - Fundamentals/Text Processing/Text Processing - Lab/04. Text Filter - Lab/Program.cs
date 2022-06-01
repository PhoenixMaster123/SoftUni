using System;
using System.Linq;

namespace _04._Text_Filter___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWord = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            foreach (string word in bannedWord)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
