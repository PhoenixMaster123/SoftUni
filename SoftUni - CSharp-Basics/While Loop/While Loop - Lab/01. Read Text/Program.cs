using System;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            while (names != "Stop") 
            {               
                Console.WriteLine(names);
                names = Console.ReadLine();
            }
            
        }
    }
}
