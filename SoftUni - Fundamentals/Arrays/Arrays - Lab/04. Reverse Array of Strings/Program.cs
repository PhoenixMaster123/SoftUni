using System;

namespace _04._Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        { 
           string [] words = Console.ReadLine().Split(' ');
            string[] values = new string[words.Length];
            for (int i = 0;i<values.Length;i++)
            {
                values[i] = words[i].Trim();
            }
            for (int i = values.Length - 1; i >= 0; i--)

            {
                Console.Write(values[i] + " ");
            }
          //  Console.WriteLine(string.Join(" ", values));
        }
    }
}
