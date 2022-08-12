using System.IO;
using System;
using System.Collections.Generic;
using System.Globalization;
using LessonInterface.Entities;
using LessonInterface.Services;


namespace LessonInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter rental data: ");
            //Console.Write("Car model: ");
            //string model = Console.ReadLine();

            //Console.Write("Pickup (dd/MM/YYYY hh:mm): ");
            //DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

            //Console.Write("Return (dd/MM/YYYY hh:mm): ");
            //DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

            //CarRental cr = new CarRental(start, finish, new Vehicle(model));

            //Console.Write("Enter Price per Hour: ");
            //double priceH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.Write("Enter Price per Day: ");
            //double priceD = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //RentalService rs = new RentalService(priceH, priceD, new BrazilTaxService());
            //rs.ProcessInvoice(cr);

            //Console.Write(cr.Invoice);

            string path = @"C:\Users\017585631\Desktop\codes\Curso\LessonInterface\input.txt";
            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
