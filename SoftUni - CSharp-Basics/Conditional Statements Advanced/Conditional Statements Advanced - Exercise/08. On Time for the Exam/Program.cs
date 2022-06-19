using System;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursexam = int.Parse(Console.ReadLine());
            int minutsexam = int.Parse(Console.ReadLine());
            int cominghours = int.Parse(Console.ReadLine());
            int comingminuts = int.Parse(Console.ReadLine());

            int difference = 0;
            int hour = 0;
            int minuts = 0;

            minutsexam += hoursexam * 60;
            comingminuts += cominghours * 60;

            if(comingminuts>minutsexam)
            {
                Console.WriteLine("Late");
                difference = comingminuts - minutsexam;
                if(difference<60)
                {
                    Console.WriteLine($"{(difference)} minutes after the start");
                }
                else
                {
                    hour = difference / 60;
                    minuts = difference % 60;
                    Console.WriteLine($"{hour}:{minuts:d2} hours after the start");
                }
            }
            else if (comingminuts < minutsexam - 30)
            {
                Console.WriteLine("Early");
                difference = minutsexam - comingminuts;
                if (difference < 60)
                {
                    Console.WriteLine($"{Math.Abs(difference)} minutes before the start");
                }
                else
                {
                    hour = difference / 60;
                    minuts = difference % 60;
                    Console.WriteLine($"{hour}:{minuts:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
                difference = minutsexam - comingminuts;
                Console.WriteLine($"{difference} minutes before the start");
            }


           /* if (hoursexam == minutsexam && cominghours == comingminuts ||minutsexam <=30 && cominghours==comingminuts)
            {
                Console.WriteLine("On time");
            }*/


        }
    }
}
