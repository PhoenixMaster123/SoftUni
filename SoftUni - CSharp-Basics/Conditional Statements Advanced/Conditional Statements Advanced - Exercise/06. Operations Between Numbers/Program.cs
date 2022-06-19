using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = int.Parse(Console.ReadLine());
            double n2 = int.Parse(Console.ReadLine());
            string operators = Console.ReadLine();
            double result = 0.0;
            if(operators=="+")
            {
                result = n1 + n2;
                if (result % 2 == 0) 
                {
                    Console.WriteLine($"{n1} + {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} + {n2} = {result} - odd");
                }
            }
            else if (operators == "-")
            {
                result = n1 - n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} - {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} - {n2} = {result} - odd");
                }
            }
            else if (operators == "*")
            {
                result = n1 * n2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} * {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} * {n2} = {result} - odd");
                }
            }
            else if(operators == "/")
            {
                result = n1 / n2;
                if (n2!=0)
                {
                    Console.WriteLine($"{n1} / {n2} = {result:F2}");
                }
                else if (n2==0) 
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
            }
            else if (operators == "%")
            {
                result = n1 % n2;

                if (n2!=0)
                {
                    Console.WriteLine($"{n1} % {n2} = {result}");
                }
                else if(n2==0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
            }
        }
    }
}


            /*switch (operators)
            {
                case "+":
                    int result = n1 + n2;
                    int even = result % 2;
                    if (even==result)
                    {

                        Console.WriteLine($"{result} even");
                    }
                    break;*/
        
        
    
