using System;

namespace Weekend_or_Working_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            string days = Console.ReadLine();
            switch(days)
            {
                case "Monday":
                    Console.WriteLine("Working day");
                    break;
                case "Tuesday":
                    Console.WriteLine("Working day");
                    break;
                case "Wednesday":
                    Console.WriteLine("Working day");
                    break;
                case "Thursday":
                    Console.WriteLine("Working day");
                    break;
                case "Friday":
                    Console.WriteLine("Working day");
                    break;              
                case "Saturday":
                    Console.WriteLine("Weekend");
                    break;
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }
        }
    }
}
