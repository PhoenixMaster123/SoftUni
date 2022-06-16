using System;

namespace Odd___Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());



            double oddsum = 0;
            double oddmax = double.MinValue;
            double oddmin = double.MaxValue;
            double evensum = 0;
            double evenmax = double.MinValue;
            double evenmin = double.MaxValue;


            for (int i = 1; i <= n; i++)
            {
                double currentnumber = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evensum += currentnumber;

                    if (currentnumber > evenmax)
                    {
                        evenmax = currentnumber;
                    }
                    if (currentnumber < evenmin)
                    {
                        evenmin = currentnumber;
                    }


                }
                else
                {
                    oddsum += currentnumber;

                    if (currentnumber > oddmax)
                    {
                        oddmax = currentnumber;
                    }
                    if (currentnumber < oddmin)
                    {
                        oddmin = currentnumber;
                    }
                }


            }





            Console.WriteLine($"OddSum={oddsum:f2},");

            if (oddmin == double.MaxValue)
            {

                Console.WriteLine($"OddMin={"No"},");
            }
            else
            {
                Console.WriteLine($"OddMin={oddmin:f2},");
            }

            if (oddmax == double.MinValue)
            {

                Console.WriteLine($"OddMax={"No"},");
            }
            else
            {
                Console.WriteLine($"OddMax={oddmax:f2},");
            }

            // Console.WriteLine($"OddMax={oddmin:f2},");
            Console.WriteLine($"EvenSum={evensum:f2},");

            if (evenmin == double.MaxValue)
            {

                Console.WriteLine($"EvenMin={"No"},");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenmin:f2},");
            }
            // Console.WriteLine($"EvenMin={evenmax:f2},");

            if (evenmax == double.MinValue)
            {

                Console.WriteLine($"EvenMax={"No"}");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenmax:f2}");
            }
            // Console.WriteLine($"EvenMax={evenmin:f2}");

        }
    }
}
