using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Desafio10
{
    class TaxCalculator
    {
        private double[] _lowerLimit;
        private double[] _upperLimit;
        private double[] _tax;
        private double _lastLimit;

        public TaxCalculator(double[] lowerLimit, double[] upperLimit, double[] tax, double lastLimit)
        {
            _lowerLimit = lowerLimit;
            _upperLimit = upperLimit;
            _tax = tax;
            _lastLimit = lastLimit;
        }

        private double CalculateTax(double salary)
        {
            if (salary < 0)
                return 0;

            double imposto = 0;
            for (int i = 0; i < _upperLimit.Length; i++)
            {
                if (salary - _lowerLimit[i] < 0 && salary - _upperLimit[i] < 0)
                    break;

                if (_upperLimit[i] == _lastLimit)
                {   
                    imposto += (salary - _lastLimit) * _tax[i];
                    break;
                }

                if (salary - _upperLimit[i] < 0)
                    imposto += (salary - _lowerLimit[i]) * _tax[i];
                else
                    imposto += (_upperLimit[i] - _lowerLimit[i]) * _tax[i];
            }

            return imposto;
        }

        public string GetTaxes(double salary)
        {
            double imposto = CalculateTax(salary);
            return imposto > 0 ? "R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture) : "Isento";
        }
    }
}
