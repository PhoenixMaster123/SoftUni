using System;
using System.Linq;

namespace Exercise___02._Vowels_Count
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //////////////////////////////////////////////// Varian 1 - My ///////////////////////////////
        //    string vowels = Console.ReadLine().ToLower();
        //    Console.WriteLine(GetCountVowels(vowels));

        //    static int GetCountVowels(string word)
        //    {
        //        int count = 0;
        //        char[] vowels = word.ToCharArray();          
        //        for (int i = 0; i < vowels.Length; i++)
        //        {
        //            if (vowels[i] == 'a')
        //            {
        //                count++;
        //            }
        //            else if (vowels[i] == 'o')
        //            {
        //                count++;
        //            }
        //            else if (vowels[i] == 'e')
        //            {
        //                count++;
        //            }
        //            else if (vowels[i] == 'i')
        //            {
        //                count++;
        //            }
        //            else if (vowels[i] == 'u')
        //            {
        //                count++;
        //            }
        //        }
        //        return count;

        //    }
        //}
        //////////////////////////////////////////////////////////// Second Variant ///////////////////////////////////////
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int vowelCount = GetCountVowels(word);
            Console.WriteLine(vowelCount);
        }
        static int GetCountVowels(string word)
        {           
            char[] vowels = new char[] { 'a', 'o', 'e', 'i', 'u' };
            int vowelCount = 0;
            foreach (char vowel in word.ToLower())
            {
                if(vowels.Contains(vowel))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
    }
}

