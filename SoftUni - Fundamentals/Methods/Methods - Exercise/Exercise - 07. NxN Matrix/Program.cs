using System;

namespace Exercise___07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////// First Variant //////////////////////////////
           
            // int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int k = 1; k <= n; k++)
            //    {
            //        Console.Write($"{n} ");
            //    }
            //    Console.WriteLine();
            //}

            ///////////////////////////////////////////////// Second Variant ////////////////////////////////
            int n = int.Parse(Console.ReadLine());          
            Console.WriteLine(NxNMatrix(n));
        }
        static int NxNMatrix(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= n; k++)
                {
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
               
            }
            return n;
            
           
           
        }
    }
}
