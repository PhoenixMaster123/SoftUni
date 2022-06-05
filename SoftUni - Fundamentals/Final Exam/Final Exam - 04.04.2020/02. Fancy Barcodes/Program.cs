using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Problem_2___Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"@#+[A-Z][A-Za-z\d]{4,}[A-Z]@#+");
            int barcodeCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < barcodeCount; i++)
            {
                string barcode = Console.ReadLine();
                if (pattern.IsMatch(barcode))
                {
                    char[] digits = barcode.Where(x => char.IsDigit(x)).ToArray();
                    if (digits.Length == 0)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {string.Join("", digits)}");
                    }
                }

                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
