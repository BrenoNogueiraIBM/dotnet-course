using System;
using System.Globalization;

namespace Curso
{
    class Breno
    {
        static void Main(string[] args)
        {
            ContaBancaria conta; 

            Console.Write("Entre o Numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n): ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, deposito);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados :");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre um valor para depósito: ");
            double deposito = double.Parse  (Console.ReadLine());
            conta.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            conta.Deposito(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);


            //Console.WriteLine("Digite o valor do raio: ");
            //double raio = double.Parse(Console.ReadLine());


            //Console.WriteLine("Circunferência: " + Calculadora.Circunferencia(raio));
            //Console.WriteLine("Circunferência: " + Calculadora.Volume(raio));
            //Console.WriteLine("Circunferência: " + Calculadora.Pi);

        }
    }
}