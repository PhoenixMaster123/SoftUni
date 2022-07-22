using System;

namespace _01._Square_Root
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int num = int.Parse(Console.ReadLine());
            try
            {


                if (num < 0)
                {
                    //Console.WriteLine("Invalid number."); 
                    throw new Exception("Invalid number.");
                    
                }
                else
                {
                    double result = Math.Sqrt(num);
                    Console.WriteLine(result);
                    Console.WriteLine("Goodbye.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Goodbye.");
            }
           
           
            
        }
    }
}
