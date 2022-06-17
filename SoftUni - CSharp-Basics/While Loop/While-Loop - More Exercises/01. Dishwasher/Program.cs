using System;

namespace Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottlesDetergent = int.Parse(Console.ReadLine());
            bottlesDetergent *= 750;
            string numberOfContainers = string.Empty;
            int containers = 0;
            int counter = 0;
            int numberOfDishesWashed = 0;
            int numberOfPotsWashed = 0;

            while (true)
            {
                numberOfContainers = Console.ReadLine();
                if (numberOfContainers == "End")
                {
                    break;
                }
                counter++;
                if (counter % 3 == 0)
                {
                    containers = int.Parse(numberOfContainers);
                    numberOfPotsWashed += containers;
                    bottlesDetergent -= containers * 15;
                }
                else
                {
                    containers = int.Parse(numberOfContainers);
                    numberOfDishesWashed += containers;
                    bottlesDetergent -= containers * 5;
                }
                if (bottlesDetergent < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(bottlesDetergent)} ml. more necessary!");
                    return;
                }
            }
            Console.WriteLine($"Detergent was enough!");
            Console.WriteLine($"{numberOfDishesWashed} dishes and {numberOfPotsWashed} pots were washed.");
            Console.WriteLine($"Leftover detergent {bottlesDetergent} ml.");
        }
        /*string bottles = Console.ReadLine();
        int bottle = 0;
        int plate = 0;
        int pot = 0;
        int i = 0;
        int allplates = 0;
        int allpots = 0;
        while(bottles!="End")
        {
            bottle = int.Parse(bottles);
            bottle *= 750;
            int dishes = int.Parse(Console.ReadLine());
            allplates += dishes;                
            plate = dishes * 5 ;
            bottle -= plate;

            if(i==3)
            {
                allpots += pot;
                pot = dishes*15;
                bottle -= pot;

            }
            if(i>3)
            {
                dishes = 0;
            }

            i++;


        }
        if (bottle >= 0)
        {
            Console.WriteLine("Detergent was enough!");
            Console.WriteLine($"{allplates} dishes and {allpots} pots were washed.");
            Console.WriteLine($"Leftover detergent {bottle} ml");
        }
        else
        {
            Console.WriteLine($"Not enough detergent, {bottle} ml. more necessary!");
        }*/

    }
    }

