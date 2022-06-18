using System;

namespace Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            switch(animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                case "crocodile":
                    Console.WriteLine("reptile");
                    break;
                case "tortoise":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;

            }
        }
    }
}
