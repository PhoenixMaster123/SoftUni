using System;

namespace _04._Cinema_Voucher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int voucherValue = int.Parse(Console.ReadLine());
            string command;
            int priceMovie = 0;
            int priceOthers = 0;
            char[] chars;
            int tickets = 0;
            int others = 0;
            while((command = Console.ReadLine())!="End")
            {
                string purchase = command;
                
                if(purchase.Length > 8)
                {
                    chars = purchase.ToCharArray();
                    for (int i = 0; i < chars.Length; i++)
                    {
                        if(i < 2)
                        {
                            priceMovie+=chars[i];        
                        }
                        else
                        {
                            break;
                        }

                    }
                    if(priceMovie <= voucherValue)
                    {
                        voucherValue -= priceMovie;
                        tickets++;
                        priceMovie = 0;
                    }
                    else
                    {
                        break;
                    }
                   
                }
                else
                {
                    chars = purchase.ToCharArray();
                    for (int i = 0; i < chars.Length; i++)
                    {
                        if (i < 1)
                        {
                            priceOthers += chars[i];
                            
                        }
                        else
                        {
                            break;
                        }

                    }
                    if (priceOthers <= voucherValue)
                    {
                        voucherValue -= priceOthers;
                        others++;
                        priceOthers = 0;
                    }
                    else
                    {
                        break;
                    }
                    
                }        
            }
            Console.WriteLine(tickets);
            Console.WriteLine(others);
        }
    }
}
