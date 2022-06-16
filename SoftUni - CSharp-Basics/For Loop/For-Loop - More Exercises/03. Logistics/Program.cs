using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int tovar = int.Parse(Console.ReadLine());
            double sum = 0;
            double microbus = 0;
            double truck = 0;
            double train = 0;
            double microresult = 0;           
            double truckresult = 0;
            double trainresult = 0;
            double alltons = 0;
            for (int i = 1; i <= tovar; i++)
            {
                int tons = int.Parse(Console.ReadLine());
                sum += tons;
                if (tons <= 3)
                {     
                    
                     microresult += tons;               
                    microbus = microresult * 200;
                }
                else if (tons >= 4 && tons <= 11)
                {
                    
                     truckresult += tons;
                    truck = truckresult * 175;

                }
                else
                {                    
                   
                     trainresult += tons;
                    train = trainresult * 120;
                }
               
                 alltons = microresult + truckresult + trainresult;
            }
           
            sum = (microbus + truck + train) / alltons;
            double micro = microresult / alltons * 100;
            double buss = truckresult / alltons * 100;
            double trainn = trainresult / alltons * 100;
            Console.WriteLine($"{sum:F2}");
            Console.WriteLine($"{micro:F2}%");
            Console.WriteLine($"{buss:F2}%");
            Console.WriteLine($"{trainn:F2}%");




        }
    }
}
