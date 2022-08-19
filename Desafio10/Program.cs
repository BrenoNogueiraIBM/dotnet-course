using System;
using System.Globalization;


namespace Desafio10
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator tax = new TaxCalculator(
                    new double[] { 0, 2000.01, 3000.01, 4500.01 },
                    new double[] { 2000.00, 3000.00, 4500.00, 4500.01 },
                    new double[] { 0, 0.08, 0.18, 0.28 },
                    4500.01
                    );

            while (true)
            {
                Console.Write("Caro cidadão Lisarbiano, digite seu salário: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine(tax.GetTaxes(salary));
            }
        }
    }
}
