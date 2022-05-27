using System;
using System.Text;

namespace _07._Repeat_String
{
    internal class Program
    {
        //////////////////////////////////// My Variant /////////////////////////////////////
        //static void Main(string[] args)
        //{
        //  string word = Console.ReadLine();
        //  int count = int.Parse(Console.ReadLine());
        //    CopyWord(word, count);
        //}
        //static void CopyWord(string word, int count)
        //{
        //    for (int i = 1; i <= count; i++)
        //    {
        //        Console.Write(word);
        //    }
        //}
        ///////////////////////////////// Second Variant ////////////////////////////
        //static void Main(string[] args)
        //{
        //    string templete = Console.ReadLine();
        //    int repates = int.Parse(Console.ReadLine());
        //    Console.WriteLine(RepeatString(templete, repates)); 
        //}
        //static string RepeatString(string template, int repates)
        //{
        //    string result = string.Empty; // create always new strings
        //    for (int i = 0; i < repates; i++)
        //    {
        //        result+=template; // slow
        //    }
        //    return result;
        //}
        ///////////////////////////////// Third Variant //////////////////////////// Best Variant
        static void Main(string[] args)
        {
            string templete = Console.ReadLine();
            int repates = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(templete, repates));
        }
        static string RepeatString(string template, int repates)
        {
            StringBuilder stringBuilder = new StringBuilder(); // never create new string, but make massiv string!!! faster
            for (int i = 0; i < repates; i++)
            {
                stringBuilder.Append(template);
            }
            return stringBuilder.ToString();
        }
    }
}
