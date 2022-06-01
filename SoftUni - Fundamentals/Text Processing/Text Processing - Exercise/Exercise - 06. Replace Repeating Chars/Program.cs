using System;
using System.Linq;

namespace Exercise___06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToList();

            for (int i = 0; i < text.Count - 1; i++)
            {
                char curr = text[i];
                char next = text[i + 1];
                if (curr == next)
                {
                    text.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join("", text));
        }
    }
}
