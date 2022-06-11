using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());         
            int point = 0;
            double average = 0;
            double percent = 0;
            int wons = 0;
            point = startPoints;

            for (int i = 0; i < tournaments; i++)
            {
                string currentStage = Console.ReadLine();
                if (currentStage == "F")
                {

                    point += 1200;
                }
                else if (currentStage == "W") 
                {
                    point += 2000;
                    wons++;
                }
                 else if (currentStage == "SF") 
                {
                    point += 720; 
                }
            }
            average = (point - startPoints) / tournaments;
            percent = ((double) wons / tournaments) * 100;
            Console.WriteLine($"Final points: {point}");
            Console.WriteLine($"Average points: {Math.Floor(average)}");
            Console.WriteLine($"{percent:F2}%");
        }
    }
}
