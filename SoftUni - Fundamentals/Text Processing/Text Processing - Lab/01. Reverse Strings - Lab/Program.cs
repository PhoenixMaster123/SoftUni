using System;
using System.Linq;

namespace _01._Reverse_Strings___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();          
            while (command!="end")
            {

                char[] wordArray = command.ToCharArray();
                Array.Reverse(wordArray);
                string reverseWord = new string(wordArray);
                Console.WriteLine($"{command} = {reverseWord}");
                command = Console.ReadLine();
              
            }
           

           
          


        }
    }
}
