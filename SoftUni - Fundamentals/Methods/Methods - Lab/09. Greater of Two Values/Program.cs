using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if(type == "int")
            {
                int number = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(number, second)); 
            }
            else if(type == "char")
            {
                char templete = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(templete, second));
            }
            else
            {
                string alphabet = Console.ReadLine();
                string secondAlphabet = Console.ReadLine();
                Console.WriteLine(GetMax(alphabet, secondAlphabet));
            }
        }
        static int GetMax(int number, int second)
        {

            if (number > second) 
            {
                return number;
            }    
            else
            {
               return second;
            }

        }
        static string GetMax(string templete, string secondTemplete)
        {
          
            if (templete.CompareTo(secondTemplete) > 0 )
            {
                return templete;
            }
            else
            {
                return secondTemplete;
            }
        }
        static char GetMax(char alphabet, char secondalphabet)
        {
           
            if (alphabet > secondalphabet)
            {
               return alphabet;
            }
            else
            {
                return secondalphabet;
            }
        }
    }
}
