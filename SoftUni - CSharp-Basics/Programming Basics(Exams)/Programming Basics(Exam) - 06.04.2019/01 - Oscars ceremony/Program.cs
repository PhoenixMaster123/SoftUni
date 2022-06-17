using System;

namespace T1___Oscars_ceremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());
            double statuet = 0.3;
            double keturing = 0.15;

            double resultstat = rent - rent * statuet;
            double resultketuring = resultstat - resultstat * keturing;
            double sound = resultketuring / 2;

            Console.WriteLine($"{rent + resultstat + resultketuring + sound:F2}");
        }
    }
}
