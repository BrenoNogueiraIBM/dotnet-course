using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    public class Entrada
    {
        public static void EntradaCurso()
        {
            Printer.ColorWriteLine("Entre com seu nome completo: ", ConsoleColor.DarkGreen);
            string nome = Console.ReadLine();

            Printer.ColorWriteLine("Quantos quartos tem na sua casa?: ", ConsoleColor.DarkGreen);
            int quartos = int.Parse(Console.ReadLine());

            Printer.ColorWriteLine("Entre o preço de um produto: ", ConsoleColor.DarkGreen);
            double preco = double.Parse(Console.ReadLine());

            Printer.ColorWriteLine("Entre seu último nome, idade e altura (na mesma linha): ", ConsoleColor.DarkGreen);
            string[] strings = Console.ReadLine().Split(" ");

            string ultimoNome = strings[0];
            int idade = int.Parse(strings[1]);
            double altura = double.Parse(strings[2]);

            Printer.ColorWriteLine(nome, ConsoleColor.DarkBlue);
            Printer.ColorWriteLine("" + quartos, ConsoleColor.DarkBlue);
            Printer.ColorWriteLine("" + preco, ConsoleColor.DarkBlue);
            Printer.ColorWriteLine("" + ultimoNome, ConsoleColor.DarkBlue);
            Printer.ColorWriteLine("" + idade, ConsoleColor.DarkBlue);
            Printer.ColorWriteLine($"{altura:F2}", ConsoleColor.DarkBlue);

            Printer.ColorWriteLine("Breno da Silva Nogueira \n", ConsoleColor.Black);


            //string produto1 = "Computador";
            //string produto2 = "Mesa de Escritório";
            //double preco1 = 2100.0;
            //double preco2 = 650.50;
            //string Breno = Console.ReadLine();
            //Printer.ColorWriteLine(Breno, ConsoleColor.Blue);
            //string CallOfDuty = Console.ReadLine();
            //Printer.ColorWriteLine(CallOfDuty, ConsoleColor.Magenta);
            //Console.WriteLine("Produtos:");
            //Console.WriteLine($"{produto1}, cujo preco é ${preco1:F2}");
            //Console.WriteLine($"{produto2}, cujo preco é ${preco2:F2}\n");
        }
    }
}
