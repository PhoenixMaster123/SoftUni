using System;

namespace _07._House_Painting
{
    
        class Program
        {
            static void Main(string[] args)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());

                double walls = (x * y) * 2;
                double windows = (1.5 * 1.5) * 2;
                double combine = walls - windows;
                double backwall = x * x;
                double enter = 1.2 * 2;
                double combine2 = 2 * backwall - enter;
                double result = combine + combine2;
                result /= 3.4;

                //roof
                double roof = 2 * (x * y);
                // triangles of roof
                double triangles = 2 * (x * h / 2);
                double roofresult = roof + triangles;
                double finalresultredpaint = roofresult / 4.3;

                Console.WriteLine("{0:0.00}", result);
                Console.WriteLine("{0:0.00}", finalresultredpaint);

            }
        }
    }

