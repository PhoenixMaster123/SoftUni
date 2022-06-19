using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayforrest = int.Parse(Console.ReadLine());
            string whatroom = Console.ReadLine().ToLower();
            string note = Console.ReadLine();

            double roomforperson = 18.00;
            double aparthment = 25.00;
            double presidentaparthment = 35.00;
            //double nights = 0;

            if (whatroom == "room for one person")
            {
                dayforrest = dayforrest - 1;
                double price = dayforrest * roomforperson;
                if (note == "positive")
                {
                    double difference = price + price * 0.25;
                    Console.WriteLine($"{difference:F2}");
                }
                else if (note == "negative")
                {
                    double difference = price + price * 0.10;
                    Console.WriteLine($"{difference:F2}");
                }
            }
            /////////// vqrno
            else if (whatroom == "apartment")
            {
                dayforrest = dayforrest - 1;
                double price = dayforrest * aparthment;
                double difference = 0;
                if (dayforrest < 10)
                {
                     difference = price - price * 0.30;
                  
                }
                else if (dayforrest >= 10 && dayforrest <= 15)
                {
                     difference = price - price * 0.35;
                    
                }
                else if (dayforrest > 15)
                {
                     difference = price - price * 0.50;
                   
                }
                if (note == "positive")
                {
                    double something = difference +difference* 0.25 ;
                    Console.WriteLine($"{something:F2}");
                }
                else if (note == "negative")
                {
                    double something = difference - difference * 0.10;
                    Console.WriteLine($"{something:F2}");
                }
                
            }

            else if (whatroom == "president apartment")
            {
                dayforrest = dayforrest - 1;
                double price = dayforrest * presidentaparthment;
                double difference = 0;
                if (dayforrest < 10)
                {
                     difference = price - price * 0.10;
                    
                }
                else if (dayforrest >= 10 && dayforrest <= 15)
                {
                     difference = price - price * 0.15;
                   
                }
                else if (dayforrest > 15)
                {
                     difference = price - price * 0.20;
                    
                }
                if (note == "positive")
                {
                    double something = difference + difference * 0.25;
                    Console.WriteLine($"{something:F2}");
                }
                else if (note == "negative")
                {
                    double something = difference - difference * 0.10;
                    Console.WriteLine($"{something:F2}");
                }
            }
        }
    }
}

            

        
    

