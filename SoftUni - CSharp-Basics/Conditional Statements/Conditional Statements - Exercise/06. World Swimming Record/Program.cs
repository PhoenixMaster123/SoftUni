using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double seconds = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeseconds = double.Parse(Console.ReadLine());

            double metersinseconds = meters * timeseconds;//vqrno
            double slow = meters / 15.0;
            slow = Math.Floor(slow) * 12.5; //vqrno
            double alltime = metersinseconds + slow;//vqrno

           // Console.WriteLine(alltime>seconds ? $"No, he failed! He was {alltime:F2} seconds slower.": $"Yes, he succeeded! The new world record is {Math.Abs(alltime):F2} seconds.");
            if (alltime >= seconds)
                
            {
                alltime -= seconds; //vqrno
                Console.WriteLine($"No, he failed! He was {alltime:F2} seconds slower.");
            }
            else if(alltime < seconds)
            {
                //double time = alltime;
                Console.WriteLine($"Yes, he succeeded! The new world record is {(alltime):F2} seconds.");
            }
        }
    }
}
