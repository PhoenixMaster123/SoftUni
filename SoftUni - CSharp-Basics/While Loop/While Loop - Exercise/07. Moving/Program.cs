using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int freespace = width * lenght * height;

            int cube = 0;
            string command = Console.ReadLine();
            while (command != "Done") 
            {
                int current = int.Parse(command);
                cube += current;
                if(freespace<cube)
                {
                    int needed = cube - freespace;
                    Console.WriteLine($"No more free space! You need {needed} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();

            }
            if(command=="Done")
            {
                int cubic = freespace - cube;
                Console.WriteLine($"{cubic} Cubic meters left.");
            }
        }
    }
}
