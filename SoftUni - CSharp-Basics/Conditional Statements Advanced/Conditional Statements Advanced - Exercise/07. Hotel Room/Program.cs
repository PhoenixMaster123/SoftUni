using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int sleepDays = int.Parse(Console.ReadLine());

            double apartment = 0.00;
            double studio = 0.00;

            double totalA = 0.00;
            double totalS = 0.00;

            switch (month)
            {
                case "May":
                case "October":
                    apartment = 65;
                    studio = 50;

                    if (sleepDays <= 7)
                    {
                        totalA = apartment * sleepDays;
                        totalS = studio * sleepDays;
                    }
                    else if (sleepDays > 7 && sleepDays <= 14)
                    {
                        totalS = (studio * sleepDays) * 0.95;
                        totalA = apartment * sleepDays;
                    }
                    else if (sleepDays > 14)
                    {
                        totalS = (studio * sleepDays) * 0.70;
                        totalA = (apartment * sleepDays) * 0.90;
                    }
                    break;
                case "June":
                case "September":
                    apartment = 68.70;
                    studio = 75.20;

                    if (sleepDays <= 14)
                    {
                        totalA = apartment * sleepDays;
                        totalS = studio * sleepDays;
                    }
                    else if (sleepDays > 14)
                    {
                        totalS = (studio * sleepDays) * 0.80;
                        totalA = (apartment * sleepDays) * 0.90;
                    }
                    break;
                case "July":
                case "August":
                    apartment = 77;
                    studio = 76;

                    if (sleepDays <= 14)
                    {
                        totalA = apartment * sleepDays;
                        totalS = studio * sleepDays;
                    }
                    else if (sleepDays > 14)
                    {
                        totalA = (apartment * sleepDays) * 0.90;
                        totalS = studio * sleepDays;
                    }
                    break;
            }

            Console.WriteLine($"Apartment: {totalA:f2} lv.");
            Console.WriteLine($"Studio: {totalS:f2} lv.");
        }
    }
}