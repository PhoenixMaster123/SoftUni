using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double academicPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

           

            double sumPoint = academicPoints;
            bool isFound = false;
            for (int i=0;i<n;i++)
            {
                
                string jury = Console.ReadLine();
                double juryPoints = double.Parse(Console.ReadLine());

                double momentsPoints = (jury.Length * juryPoints) / 2;
                sumPoint += momentsPoints;
                if (sumPoint >= 1250.5)
                {
                    isFound = true;
                    break;
                }

            }
            if (isFound)
            {
                Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {sumPoint:F1}!");
            }
            else
            {
                double neededpoints = 1250.5 - sumPoint;
                Console.WriteLine($"Sorry, {actor} you need {neededpoints:F1} more!");
            }
        }
    }
}
