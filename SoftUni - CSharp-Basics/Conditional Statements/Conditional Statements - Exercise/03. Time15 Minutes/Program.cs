using System;

namespace Time15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minuts = int.Parse(Console.ReadLine());
            int total = hours + minuts;            
            minuts += 15;

            if(minuts>=60)
            {
                minuts -= 60;
                hours += 1;
            }
            if(hours>=24)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{minuts:d2}");
        }
    }
}
        
    

