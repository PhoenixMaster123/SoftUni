using System;

namespace _04._Renovation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            double percent = int.Parse(Console.ReadLine());
            
            string command;
            double size = height * width * 4;
            size -= size * (percent/100);

            while ((command = Console.ReadLine()) != "Tired!")
            {
                int literPaint = int.Parse(command);
                size -= literPaint;
                if (size <= 0)
                {
                    break;
                }
            }
            if(size < 0)
            {
                Console.WriteLine($"All walls are painted and you have {Math.Abs(size)} l paint left!");
            }
            else if(size == 0)
            {
                Console.WriteLine($"All walls are painted! Great job, Pesho!");
            }
            else
            {
                Console.WriteLine($"{size} quadratic m left.");
            }
           
        }
    }
}
