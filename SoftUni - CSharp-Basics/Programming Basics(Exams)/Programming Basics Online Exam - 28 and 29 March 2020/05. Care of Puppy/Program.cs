using System;

namespace T5___Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int buyedFoodForDogInKg = int.Parse(Console.ReadLine());
            buyedFoodForDogInKg = buyedFoodForDogInKg * 1000;
            string stop = "Adopted";
            int result = 0;

            for (int i = 0; i <= int.MaxValue; i++)
            {
                string eatingFooodString = Console.ReadLine();

                if (eatingFooodString == stop)
                {
                    break;
                }
                else
                {
                    int kgEatingFood = Int32.Parse(eatingFooodString);
                    result += kgEatingFood;
                }
            }

            if (result > buyedFoodForDogInKg)
            {
                Console.WriteLine($"Food is not enough. You need {result - buyedFoodForDogInKg} grams more.");
            }
            else
            {
                Console.WriteLine($"Food is enough! Leftovers: {buyedFoodForDogInKg - result} grams.");
            }
            /*  if (allfood < foodkilograms)
          {
              result = foodkilograms - allfood;
              Console.WriteLine($"Food is enough! Leftovers: {result} grams.");
          }
          else if (allfood > foodkilograms) 
          {
              result = allfood - foodkilograms;
              Console.WriteLine($"Food is not enough. You need {result} grams more.");
          }*/
        }
        }
    }

