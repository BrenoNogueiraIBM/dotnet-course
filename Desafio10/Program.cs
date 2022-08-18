using System;
using System.Globalization;


namespace Desafio10
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Caro cidadão Lisarbiano, digite seu salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double imposto = TaxCalculator.CalculateTax(salario);
                string text = imposto > 0 ? "R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture) : "Isento";
                Console.WriteLine(text);
            }
        }
    }
}
