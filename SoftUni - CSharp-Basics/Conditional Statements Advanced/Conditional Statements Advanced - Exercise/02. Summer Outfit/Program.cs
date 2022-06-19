using System;

namespace Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int grad = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            if (grad >= 10 && grad <= 18 && time == "Morning")
            {
                outfit = "Sweatshirt";
                shoes = "Sneakers";
            }
            else if (grad >= 10 && grad <= 18 && time == "Afternoon")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (grad >= 10 && grad <= 18 && time == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            if (grad > 18 && grad <= 24 && time == "Morning")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if(grad > 18 && grad <= 24 && time == "Afternoon")
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
            else if (grad > 18 && grad <= 24 && time == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            if (grad >= 25 && time == "Morning")
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
            }
            else if (grad >= 25 && time == "Afternoon") 
            {
                outfit = "Swim Suit";
                shoes = "Barefoot";
            }
            else if(grad >= 25 && time == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            Console.WriteLine($"It's {grad} degrees, get your {outfit} and {shoes}.");

        }
    }
}
