using System;

namespace Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double pipe1 = hours * p1;
            double pipe2 = hours * p2;
            double pipes = pipe1 + pipe2;
            

            if (pipes<=v)
            {
                /*double allLiturs = pipes / 10;
                double firstpipe = pipe1 / pipes * 100;
                double secondpipe = pipe2 / pipes * 100;*/
                double allLiturs = (pipes / v) * 100;
                double firstpipe = pipe1 / pipes * 100;
                double secondpipe = pipe2 / pipes * 100;

                Console.WriteLine($"The pool is {allLiturs:F2}% full. Pipe 1: {firstpipe:F2}%. Pipe 2: {secondpipe:F2}%.");

            }
            else if(pipes>v)
            {
                double needed = pipes - v;
                Console.WriteLine($"For {hours:F2} hours the pool overflows with {(needed):F2} liters.");
            }
        }
    }
}





