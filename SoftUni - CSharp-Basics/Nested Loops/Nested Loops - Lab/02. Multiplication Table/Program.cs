using System;

namespace Nested_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                for(int j =1; j<=10;j++)
                {
                    int number = i * j;
                    Console.WriteLine($"{i} * {j} = {number}");
                }
               
            }
        }
    }
}
