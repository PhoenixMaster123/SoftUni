using System;

namespace _01._Randomize_Words___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
           Random random = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = random.Next(0, words.Length);
                string currentWord = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = currentWord;
               
            }
            foreach (string word in words)
            {
                
                Console.WriteLine(word);
            }
           // Console.WriteLine(random.Next(1,10)); // generate random number
        }
    }
}
