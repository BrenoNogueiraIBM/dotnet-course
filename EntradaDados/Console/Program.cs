using System;

namespace ConsoleEntrada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor 1: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 2: ");
            int valor2 = int.Parse(Console.ReadLine());

            long soma = (long) valor1 + valor2;

            Console.WriteLine("A soma é: " + soma);
            Console.ReadKey();
        }
    }
}
