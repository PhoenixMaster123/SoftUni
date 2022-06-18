using System;

namespace Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursday = int.Parse(Console.ReadLine());
            string days = Console.ReadLine();
            if (hoursday >= 10 && hoursday < 18 || days == "Monday" && days == "Tuesday" && days == "Wednesday" && days == "Thursday" && days == "Friday" && days == "Saturday") 
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
            
        }
    }
}
