using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            string num = Console.ReadLine();
            while(num!="Stop")
            {
                int number = int.Parse(num);             
                if(max<number)
                {
                    max = number;
                   
                }
                num = Console.ReadLine();
                
            }
            Console.WriteLine(max);
        }
    }
}
