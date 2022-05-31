using System;
using System.Collections.Generic;
using System.Linq;


namespace Exercise___01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            Dictionary<char,int> count = new Dictionary<char,int>();
            foreach (string word in words)
            {
                char[] chars = word.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (count.ContainsKey(chars[i]))
                    {
                        count[chars[i]]++;
                    }
                    else
                    {
                        count.Add(chars[i], 1);
                    }
                }
                
            }
            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
