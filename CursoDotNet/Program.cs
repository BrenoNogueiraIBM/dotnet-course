using System;
using System.Globalization;

namespace Curso
{
    class Breno
    {
        static void Main(string[] args)
        {

            int pessoas = int.Parse(Console.ReadLine());

            double[] alturas = new double[pessoas];
            double total = 0;
            for (int i = 0; i < pessoas; i++) {
                alturas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                total += alturas[i];
            }


            Console.WriteLine("Média é de: " + (total/pessoas) + "m");


            // ===============================================================================

            //double? x = null;
            //double? y = 10.0;

            //Console.WriteLine(x.GetValueOrDefault());
            //Console.WriteLine(y.GetValueOrDefault());

            //Console.WriteLine(x.HasValue);
            //Console.WriteLine(y.HasValue);

            //if(x.HasValue)
            //    Console.WriteLine(x.Value);
            //else
            //    Console.WriteLine("Nulo");

            //if (y.HasValue)
            //    Console.WriteLine(y.Value);
            //else
            //    Console.WriteLine("Nulo");

            //double a = x ?? 25.0;
            //double b = y ?? 50.0;

            //Console.WriteLine(a);
            //Console.WriteLine(b);



            // ===============================================================================

            //ContaBancaria conta; 

            //Console.Write("Entre o Numero da conta: ");
            //int numero = int.Parse(Console.ReadLine());

            //Console.Write("Entre o titular da conta: ");
            //string titular = Console.ReadLine();

            //Console.Write("Haverá depósito inicial? (s/n): ");
            //char resp = char.Parse(Console.ReadLine());

            //if (resp == 's' || resp == 'S')
            //{
            //    Console.Write("Entre o valor do depósito inicial: ");
            //    double deposito = double.Parse(Console.ReadLine());
            //    conta = new ContaBancaria(numero, titular, deposito);
            //}
            //else
            //{
            //    conta = new ContaBancaria(numero, titular);
            //}

            //Console.WriteLine();
            //Console.WriteLine("Dados :");
            //Console.WriteLine(conta);

            //Console.WriteLine();
            //Console.WriteLine("Entre um valor para depósito: ");
            //double deposito = double.Parse  (Console.ReadLine());
            //conta.Deposito(deposito);
            //Console.WriteLine("Dados da conta atualizados:");
            //Console.WriteLine(conta);

            //Console.WriteLine();
            //Console.WriteLine("Entre um valor para saque: ");
            //double saque = double.Parse(Console.ReadLine());
            //conta.Deposito(saque);
            //Console.WriteLine("Dados da conta atualizados:");
            //Console.WriteLine(conta);

            // ===============================================================================


            //Console.WriteLine("Digite o valor do raio: ");
            //double raio = double.Parse(Console.ReadLine());


            //Console.WriteLine("Circunferência: " + Calculadora.Circunferencia(raio));
            //Console.WriteLine("Circunferência: " + Calculadora.Volume(raio));
            //Console.WriteLine("Circunferência: " + Calculadora.Pi);

        }
    }
}