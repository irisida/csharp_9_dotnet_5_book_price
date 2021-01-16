using System;
using System.Linq;

namespace TaxCodeFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] amounts = { 100.00M, 200.00M, 300.00M };
            string[] codes = { "GB", "LU", "CH" };

            foreach (decimal amount in amounts)
            {
                foreach (string code in codes)
                {
                    decimal taxAmount = CalculateTax(amount, code);
                    Console.WriteLine($"On {amount} in {code} the after tax amount is {amount - taxAmount}");
                }
            }

        }

        static decimal CalculateTax(decimal amount, string regionCode)
        {
            decimal rate = 0.0M;

            switch (regionCode.ToUpper())
            {
                case "GB":
                    rate = 0.28M;
                    break;

                case "CH":
                    rate = 0.08M;
                    break;

                case "LU":
                    rate = 0.2M;
                    break;
            }

            return amount * rate;
        }
    }
}
