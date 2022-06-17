using System;

namespace T2___Godzilla_vs_Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double cloets = double.Parse(Console.ReadLine());
            double percent = 0;
          
            double decor = budget * 0.1;
            double sumcloets = cloets * statists;
            if (statists > 150)
            {
                 percent += sumcloets * 0.1;
            }
            sumcloets -= percent;
           
            double allsum = decor + sumcloets;
            
            if(budget>=allsum)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-allsum:F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {allsum - budget:F2} leva more.");
            }

        }
    }
}
