using System;
using System.Linq;
using System.Text;

namespace _05._Digits__Letters_and_Other___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////// Variant 1 ////////////////////////////////////////
            //string text = Console.ReadLine();

            //StringBuilder letters = new StringBuilder();
            //StringBuilder numbers = new StringBuilder();
            //StringBuilder otherCharachters = new StringBuilder();

            //foreach(char item in text)
            //{
            //    if(char.IsLetter(item))
            //    {
            //        letters.Append(item);
            //    }
            //    else if(char.IsDigit(item))
            //    {
            //        numbers.Append(item);
            //    }
            //    else
            //    {
            //        otherCharachters.Append(item);
            //    }
            //}
            //Console.WriteLine(numbers.ToString());
            //Console.WriteLine(letters.ToString());
            //Console.WriteLine(otherCharachters.ToString());

            ///////////////////////////////////////////////////////////////// Variant 2 ///////////////////////////////////////////  
            string text = Console.ReadLine();
            char[] allDigits = text.Where(item=>char.IsDigit(item)).ToArray();
            char[] allLetters = text.Where(item => char.IsLetter(item)).ToArray();
            char[] allOthers = text.Where(item => !char.IsDigit(item)&&!char.IsLetter(item)).ToArray();

           // char[] allOthers = text.Where(item => !char.IsLetterOrDigit(item).ToArray();

            Console.WriteLine(new string(allDigits));
            Console.WriteLine(new string(allLetters));
            Console.WriteLine(new string(allOthers)); // should be without new string   =>   Console.WriteLine((allOthers));

            //  Console.WriteLine(string.Join("",allDigits));      

        }
    }
}
