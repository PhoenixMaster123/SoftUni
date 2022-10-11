using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int colorEggs = int.Parse(Console.ReadLine());
            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            string color;
            for (int i = 0; i < colorEggs; i++)
            {
                color = Console.ReadLine();
                if(color == "red")
                {
                    redEggs++;
                   
                }
                else if(color == "orange")
                {
                    orangeEggs++;
                    
                }
                else if(color == "blue")
                {
                    blueEggs++;
                    
                }
                else
                {
                    greenEggs++;
                   
                }
               
            }
            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            if (redEggs > orangeEggs && redEggs > greenEggs && redEggs > blueEggs)
            {
                color = "red";
                Console.WriteLine($"Max eggs: {redEggs} -> {color}");
            }
            else if (orangeEggs > redEggs && orangeEggs > greenEggs && orangeEggs > blueEggs)
            {
                color = "orange";
                Console.WriteLine($"Max eggs: {orangeEggs} -> {color}");
            }
            else if (blueEggs > redEggs && blueEggs > greenEggs && blueEggs > orangeEggs)
            {
                color = "blue";
                Console.WriteLine($"Max eggs: {blueEggs} -> {color}");
            }
            else
            {
                color = "green";
                Console.WriteLine($"Max eggs: {greenEggs} -> {color}");
            }            
        }
    }
}
