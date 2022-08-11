using System;
using System.IO;
using System.Collections.Generic;

namespace Live1 
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc1 = new Calculadora();
            Calculadora calc2 = new Calculadora();
            Calculadora calc3 = new Calculadora();
            Calculadora calc4 = new Calculadora();
            Calculadora calc5 = new Calculadora();


            calc1.Soma(1,5);
            System.Console.WriteLine("Quantidade: " + Calculadora.Qte);
            
        }
    }
}
