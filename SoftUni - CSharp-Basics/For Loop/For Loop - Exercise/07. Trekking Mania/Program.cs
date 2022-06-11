using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            int group4 = 0;
            int group5 = 0;

            for(int i=0;i<group;i++)
            {
                int climberscounts = int.Parse(Console.ReadLine());
                if(climberscounts<6)
                {
                    group1 += climberscounts;
                }
                else if (climberscounts < 13)
                {
                    group2 += climberscounts;
                }
                else if (climberscounts < 26)
                {
                    group3 += climberscounts;
                }
                else if (climberscounts < 41)
                {
                    group4 += climberscounts;
                }
                else 
                {
                    group5 += climberscounts;
                }
            }
            int total = group1 + group2 + group3 + group4 + group5;
            double convertGroup1 = 1.0 * group1 / total * 100;
            double convertGroup2 = 1.0 * group2 / total * 100;
            double convertGroup3 = 1.0 * group3 / total * 100;
            double convertGroup4 = 1.0 * group4 / total * 100;
            double convertGroup5 = 1.0 * group5 / total * 100;

            Console.WriteLine($"{convertGroup1:F2}%");
            Console.WriteLine($"{convertGroup2:F2}%");
            Console.WriteLine($"{convertGroup3:F2}%");
            Console.WriteLine($"{convertGroup4:F2}%");
            Console.WriteLine($"{convertGroup5:F2}%");


        }
    }
}
