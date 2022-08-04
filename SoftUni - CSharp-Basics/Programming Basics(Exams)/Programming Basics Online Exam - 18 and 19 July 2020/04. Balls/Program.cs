using System;

namespace T4___Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int balls = int.Parse(Console.ReadLine());
            double result = 0;
            int red = 0;
            int orange = 0;
            int yellow = 0;
            int white = 0;
            int black = 0;
            int othercolor = 0;
            for(int i=1;i<=balls;i++)
            {
                string color = Console.ReadLine();
                if (color == "red")
                {
                    result += 5;
                    red++;
                }
                else if (color == "orange")
                {
                    result += 10;
                    orange++;
                }
                else if (color == "yellow")
                {
                    result += 15;
                    yellow++;
                }
                else if (color == "white")
                {
                    result += 20;
                    white++;
                }
                else if (color == "black")
                {
                    result = Math.Floor(result / 2);
                    black++;
                }
                else
                {
                    othercolor++;
                }
               
            }
            Console.WriteLine($"Total points: {result}");
            Console.WriteLine($"Red balls: {red}");
            Console.WriteLine($"Orange balls: {orange}");
            Console.WriteLine($"Yellow balls: {yellow}");
            Console.WriteLine($"White balls: {white}");
            Console.WriteLine($"Other colors picked: {othercolor}");
            Console.WriteLine($"Divides from black balls: {black}");
        }
    }
}
