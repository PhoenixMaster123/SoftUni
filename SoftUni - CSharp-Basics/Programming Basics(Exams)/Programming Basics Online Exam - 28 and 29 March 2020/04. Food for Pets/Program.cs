using System;

namespace T4___Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double currentBiscuits = 0;
            double buisquits = 0;        
            double dog = 0;
            double cat = 0;
            for (int i = 1; i <= days; i++) 
            {
                double dogfood = double.Parse(Console.ReadLine());
                double catfood = double.Parse(Console.ReadLine());
                dog += dogfood;
                cat += catfood;
                if (i % 3 == 0)
                {
                    currentBiscuits = (dogfood + catfood) * 0.1;
                    buisquits += currentBiscuits;
                  
                   
                }

            }
            double allfood = dog + cat;
            double allfoodresult = (allfood / food)*100;
            double alldogfood = (dog / allfood)*100;
            double allcatfood = (cat / allfood)*100;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(buisquits)}gr.");
            Console.WriteLine($"{allfoodresult:F2}% of the food has been eaten.");
            Console.WriteLine($"{alldogfood:F2}% eaten from the dog.");
            Console.WriteLine($"{allcatfood:F2}% eaten from the cat.");


        }
    }
}
