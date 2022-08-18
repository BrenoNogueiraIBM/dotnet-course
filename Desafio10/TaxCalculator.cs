using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio10
{
    static class TaxCalculator
    {
        private static double[] LimiteInferior = new double[] { 0, 2000.01, 3000.01, 4500.01 };
        private static double[] LimiteSuperior = new double[] { 2000.00, 3000.00, 4500.00, 4500.01 };
        private static double[] Taxas = new double[] { 0, 0.08, 0.18, 0.28 };
        private static double LimiteFinal = 4500.01;

        public static double CalculateTax(double salario)
        {
            if (salario < 0)
                return 0;

            double imposto = 0;
            for (int i = 0; i < LimiteSuperior.Length; i++)
            {
                if (salario - LimiteInferior[i] < 0 && salario - LimiteSuperior[i] < 0)
                    break;

                if (LimiteSuperior[i] == LimiteFinal)
                {   
                    imposto += (salario - LimiteFinal) * Taxas[i];
                    break;
                }

                if (salario - LimiteSuperior[i] < 0)
                    imposto += (salario - LimiteInferior[i]) * Taxas[i];
                else
                    imposto += (LimiteSuperior[i] - LimiteInferior[i]) * Taxas[i];
            }

            return imposto;
        }
    }
}
