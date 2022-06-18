using System;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (gender == "m" && age < 16) 
            {
                Console.WriteLine("Master");
            }
            else if(gender == "m" && age >= 16)
            {
                Console.WriteLine("Mr.");
            }
            if (gender == "f" && age < 16)
            {
                Console.WriteLine("Miss");
            }
            else if (gender == "f" && age >= 16)
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}
