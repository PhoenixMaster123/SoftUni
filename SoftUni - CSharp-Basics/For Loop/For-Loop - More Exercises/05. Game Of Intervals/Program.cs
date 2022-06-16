using System;

namespace Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int gameinput = int.Parse(Console.ReadLine());
            double result = 0;
            double low = 0;
            double medium = 0;
            double high = 0;
            double fail = 0;
            double between = 0;
            double lowbetween = 0;
            for(int i=1;i<=gameinput;i++)
            {
                double input = int.Parse(Console.ReadLine());               
                if (input >= 0 && input <= 9)
                {
                    result = result+(input * 0.2);                  
                    low++;
                }
                else if (input >= 10 && input <= 19) 
                {
                    result = result+(input * 0.3);
                    lowbetween++;
                }
                else if (input >= 20 && input <= 29)
                {
                    result = result + (input * 0.4);
                    between++;
                }
                else if (input >= 30 && input <= 39)
                {
                    result += 50;
                    medium++;
                }
                else if (input >= 40 && input <= 50)
                {                  
                    result += 100;
                    high++;
                }
                else
                {
                    if (input != 0||input>50)
                    {
                        result = result/2;
                        fail++;
                    }                  
                   
                }
               
            }
            low = (low / gameinput) * 100;
            lowbetween = (lowbetween / gameinput) * 100;
            between = (between / gameinput * 100);
            medium = (medium / gameinput) * 100;
            high = (high / gameinput) * 100;
            fail = (fail / gameinput) * 100;
            Console.WriteLine($"{result:F2}");
            Console.WriteLine($"From 0 to 9: {low:F2}%");
            Console.WriteLine($"From 10 to 19: {lowbetween:F2}%");
            Console.WriteLine($"From 20 to 29: {between:F2}%");
            Console.WriteLine($"From 30 to 39: {medium:F2}%");
            Console.WriteLine($"From 40 to 50: {high:F2}%");
            Console.WriteLine($"Invalid numbers: {fail:F2}%");

        }
    }
}
