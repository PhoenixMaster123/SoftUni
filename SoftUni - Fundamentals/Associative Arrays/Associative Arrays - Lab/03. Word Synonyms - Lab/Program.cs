using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonyms = Console.ReadLine();
                //////////////////////////////////////// Variant 1 ///////////////////////////////////
                //if(dic.ContainsKey(word))
                //{
                //    dic[word].Add(synonyms);
                   
                //}
                //else
                //{
                //    List<string> newSymList = new List<string>() { synonyms};
                //    dic.Add(word, newSymList);
                //}
                /////////////////////////////////////// Variant 2 ///////////////////////////////////
                if(!dic.ContainsKey(word))
                {
                    dic.Add(word, new List<string>());
                }
                else
                {
                    dic[word].Add(synonyms);
                }
            }
            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ",item.Value)}");
            }
        }
    }
}
