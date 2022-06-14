using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Parking_Lot___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string command = Console.ReadLine();
            HashSet<string> carNames = new HashSet<string>();
            while (command != "END") 
            {
                string[] token = command.Split(',');
                string action = token[0];
                string carNumber = token[1];
                if(action.Equals("IN"))
                {
                    carNames.Add(carNumber);
                }
                else if(action.Equals("OUT"))
                {
                    carNames.Remove(carNumber);
                }
                command = Console.ReadLine();
            }
            if(carNames.Any())
            {
                foreach (string carName in carNames)
                {
                    Console.WriteLine(carName);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
