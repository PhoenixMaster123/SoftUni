using System;
using System.Linq;

namespace _02._Repeat_Strings___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////// Variant 1 ///////////////////////////////////////////

            //string[] words = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();

            //foreach(string word in words)
            //{
            //    char[] result = word.ToCharArray();
            //    for (int i = 0; i < result.Length; i++)
            //    {
            //        string countWord = new string(result);
            //        Console.Write(countWord);
            //    }
            //}

            //////////////////////////////////////////////////////////////// Variant 2 ////////////////////////////////////////////
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string result = string.Empty;
            foreach (string word in words)
            {               
                for (int i = 0; i < word.Length; i++)
                {
                    result += word;
                }
                
            }
            Console.WriteLine(result);
        }
    }
}
