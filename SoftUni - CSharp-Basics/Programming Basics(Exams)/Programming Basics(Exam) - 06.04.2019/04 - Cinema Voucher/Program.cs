using System;

namespace T4___Cinema_Voucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int countmovie = int.Parse(Console.ReadLine());
            double average = 0;
            double sum = 0;
            double min = double.MaxValue;
            double max = double.MinValue;
            string movie1 = "";
            string movie2 = "";
            double raiting = 0;
          
            for (int i = 1; i <= countmovie; i++)
            {
                string name = Console.ReadLine();
                raiting = double.Parse(Console.ReadLine());
                sum += raiting;
                if (raiting > max)
                {
                    max = raiting;
                    movie2 = name;
                }
                else if (raiting < min) 
                {
                    min = raiting;
                    movie1 = name;
                }

            }
            average = (sum / countmovie);
            Console.WriteLine($"{movie2} is with highest rating: {max:F1}");
            Console.WriteLine($"{movie1} is with lowest rating: {min:F1}");
            Console.WriteLine($"Average rating: {average:F1}");
        }
    }
}
