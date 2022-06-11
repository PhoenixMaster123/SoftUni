using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            double p5 = 0;
            for(int i =0;i<number;i++)
            {
                int current = int.Parse(Console.ReadLine());
                if(current<200)
                {
                    p1++;
                }
                else if (current < 400)
                {
                    p2++;
                }
                else if (current < 600)
                {
                    p3++;
                }
                else if (current < 800)
                {
                    p4++;
                }
                else 
                {
                    p5++;
                }
            }
            double percentp1 = 1.0 * p1 / number * 100;
            double percentp2 = (double)p2 / number * 100; // double go pravi ako chisloto e 1 -> 1.0
            double percentp3 = (double)p3 / number * 100;
            double percentp4 = (double)p4 / number * 100;
            double percentp5 = p5 / number * 100;

            Console.WriteLine($"{percentp1:F2}%");
            Console.WriteLine($"{percentp2:F2}%");
            Console.WriteLine($"{percentp3:F2}%");
            Console.WriteLine($"{percentp4:F2}%");
            Console.WriteLine($"{percentp5:F2}%");

        }
    }
}
