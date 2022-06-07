using System;

namespace Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architect = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int hours = projects * 3;
            Console.WriteLine($"The architect {architect} will need {hours} hours to complete {projects} project/s.");
        }
    }
}
