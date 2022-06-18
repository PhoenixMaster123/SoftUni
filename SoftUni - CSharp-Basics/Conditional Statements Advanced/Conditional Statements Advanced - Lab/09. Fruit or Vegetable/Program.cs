using System;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string something = Console.ReadLine();
            if (something == "banana" || something == "apple" || something == "kiwi" || something == "cherry" || something == "lemon" || something == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (something == "tomato" || something == "cucumber" || something == "pepper" || something == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
