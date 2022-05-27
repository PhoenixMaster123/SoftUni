using System;

namespace Exercise___03._Characters_in_Range
{
    internal class Program
    {
        ////////////////////////////////////////// Variant 1 - My without Method //////////////////////////////////
        //static void Main(string[] args)
        //{
        //    char letter1 = char.Parse(Console.ReadLine());
        //    char letter2 = char.Parse(Console.ReadLine());
        //    if (letter1 < letter2)
        //    {
        //        for (int i = letter1 + 1; i < letter2; i++)
        //        {
        //            Console.Write($"{(char)i } ");
        //        }
        //    }
        //    else
        //    {
        //        for (int k = letter2 + 1; k <= letter1 - 1; k++)
        //        {
        //            Console.Write($"{(char)k } ");
        //        }
        //    }

        //}
        ////////////////////////////////////////// Variant 2 ////////////////////////////////////////////////////
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            if (letter1 < letter2)
            {
                Console.WriteLine(PrintSymbols(letter1, letter2));
                
            }
            else
            {
                Console.WriteLine(PrintReverseSymbols(letter1, letter2));
               
            }

        }
        static char PrintSymbols(char letter1, char letter2)
        {
            for (int i = letter1+1; i < letter2; i++)
            {

                Console.Write($"{(char)i } ");
            }
            return letter1;
            
        }
        static char PrintReverseSymbols(char letter1, char letter2)
        {
            for (int k = letter2 + 1; k <= letter1 - 1; k++)
            {
                Console.Write($"{(char)k } ");
            }
            return letter2;
            
        }

       
        }
    }

