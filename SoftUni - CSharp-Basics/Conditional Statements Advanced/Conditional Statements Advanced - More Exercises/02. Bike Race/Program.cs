using System;

namespace Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string typerace = Console.ReadLine();

            //junior
            double trail = 5.50;
            double crosscountry = 8;
            double downhill = 12.25;
            double road = 20;
            //senior
            double trailsenior = 7;
            double crosscountrysenior = 9.50;
            double downhillsenior = 13.75;
            double roadsenior = 21.50;

            double juniorprice = 0;
            double seniorprice = 0;
            double people = juniors + seniors;

            switch(typerace)
            {
                case "trail":
                    juniorprice = trail * juniors;
                    seniorprice = trailsenior * seniors;
                    double result = (juniorprice + seniorprice);
                    result = result - result * 0.05;
                    Console.WriteLine($"{result:F2}");
                    break;
                case "cross-country":

                    juniorprice = crosscountry * juniors;
                    seniorprice = crosscountrysenior * seniors;
                    result = (juniorprice + seniorprice);
                    result = result - result * 0.05;
                    if (people >= 50)
                    {
                        result = result - result* 0.25;
                        Console.WriteLine($"{result:F2}");
                    }
                    else
                    {
                        Console.WriteLine($"{result:F2}");
                    }
                    break;
                case "downhill":
                    juniorprice = downhill * juniors;
                    seniorprice = downhillsenior * seniors;
                    result = (juniorprice + seniorprice);
                    result = result - result * 0.05;
                    Console.WriteLine($"{result:F2}");
                    break;
                case "road":
                    juniorprice = road * juniors;
                    seniorprice = roadsenior * seniors;
                    result = (juniorprice + seniorprice);
                    result = result - result * 0.05;
                    Console.WriteLine($"{result:F2}");
                    break;


            }
        }
    }
}
