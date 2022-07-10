using System;

namespace _01._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            while (command != "END")
            {
                if (int.TryParse(command, out int valueInt))
                {
                    Console.WriteLine($"{command} is integer type");
                }
                else if (float.TryParse(command, out float valueFloat))
                {
                    Console.WriteLine($"{command} is floating point type");
                }
                else if (char.TryParse(command, out char valueChar))
                {
                    Console.WriteLine($"{command} is character type");
                }
                else if (bool.TryParse(command, out bool valueBoolean))
                {
                    Console.WriteLine($"{command} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{command} is string type");
                }

                command = Console.ReadLine();
            }
        }
    }
}
