using System;
using System.Collections.Generic;

namespace _06._Wardrobe___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int row = int.Parse(Console.ReadLine());
          var wardrobe = new Dictionary<string,Dictionary<string,int>>();
            for (int i = 0; i < row; i++)
            {
                string input = Console.ReadLine();
                 string[] token = input.Split(" -> ");  // First Variant
                //string[] token = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries); // Second Variant
                string color = token[0];

                if(!wardrobe.ContainsKey(color))
                {
                    // We don't have a color
                    wardrobe.Add(color, new Dictionary<string,int>());
                }
               
                // We have this color
                Dictionary<string,int> clothes = wardrobe[color];
                string[] outfit = input.Split(" -> ")[1].Split(",");

                foreach (string dresses in outfit)
                {
                    if(!clothes.ContainsKey(dresses))
                    {
                        clothes.Add(dresses,1);
                    }
                    else
                    {
                        clothes[dresses]++;
                    }
                }        
            }
            string[] searchOutfit = Console.ReadLine().Split(" ");
            string colorDress = searchOutfit[0];
            string dress = searchOutfit[1];
            foreach(var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                Dictionary<string, int> clothes = color.Value;
                foreach(var garments in clothes)
                {
                    if(garments.Key == dress && color.Key == colorDress)
                    {
                        Console.WriteLine($"* {garments.Key} - {garments.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {garments.Key} - {garments.Value}");
                    }
                    
                }
            }
        }
    }
}
