using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double peterbuget = double.Parse(Console.ReadLine());
            int videocarts = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double videocartsprice = videocarts * 250;
            double totalpricecpu = videocartsprice * 0.35;
            double totalrammemoryprice = videocartsprice * 0.10;

            double TotalMoney = videocartsprice + totalpricecpu * cpu + totalrammemoryprice * ram;

            if(videocarts>cpu)
            {
                TotalMoney *= 0.85;
            }
            double difference = Math.Abs(TotalMoney - peterbuget);
            if(peterbuget>=TotalMoney)
            {
                Console.WriteLine($"You have {difference:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {difference:F2} leva more!");
            }
        }
    }
}
